using System.Collections.Generic;
using Xero.NetStandard.OAuth2.Client;
using Xunit;

namespace Xero.NetStandard.OAuth2.Test.Client.WebRequestPathBuilderTests {
    public class PathParameterTests {
        private const string baseUrl = "https://api.xero.com/api.xro/2.0";
        private const string path = "/Foo/{UrlParam}";

        [Fact]
        public void Given_PathParameterContainingUnreservedCharacters_When_Building_Then_ReplacedWithPercentEncoded() {
            // See https://tools.ietf.org/html/rfc3986#section-2.3
            // See https://learn.microsoft.com/en-us/dotnet/framework/migration-guide/runtime/4.5.x#systemuri-escaping-now-supports-rfc-3986
            var unreserved = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._~";

            var builder = new WebRequestPathBuilder(baseUrl, path);

            var pathParameters = new Dictionary<string, string> {
                { "UrlParam", unreserved }
            };

            builder.AddPathParameters(pathParameters);

            Assert.Equal($"https://api.xero.com/api.xro/2.0/Foo/{unreserved}", builder.GetFullUri());
        }

        [Theory]
        [InlineData(':', "%3A")]
        [InlineData('+', "%2B")]
        [InlineData('?', "%3F")]
        [InlineData('#', "%23")]
        [InlineData('[', "%5B")]
        [InlineData(']', "%5D")]
        [InlineData('@', "%40")]
        [InlineData('!', "%21")]
        [InlineData('$', "%24")]
        [InlineData('&', "%26")]
        [InlineData('\'', "%27")]
        [InlineData('(', "%28")]
        [InlineData(')', "%29")]
        [InlineData('*', "%2A")]
        [InlineData(',', "%2C")]
        [InlineData(';', "%3B")]
        [InlineData('=', "%3D")]
        public void Given_PathParameterContainingReservedCharacters_When_Building_Then_ReplacedWithPercentEncoded(char unencoded, string encoded) {
            var builder = new WebRequestPathBuilder(baseUrl, path);

            var pathParameters = new Dictionary<string, string> {
                { "UrlParam", unencoded.ToString() }
            };

            builder.AddPathParameters(pathParameters);

            Assert.Equal($"https://api.xero.com/api.xro/2.0/Foo/{encoded}", builder.GetFullUri());
        }

        [Theory]
        [InlineData("<", "%3C")]
        [InlineData(">", "%3E")]
        [InlineData("\"", "%22")]
        [InlineData("%", "%25")]
        [InlineData("/", "%2F")]
        [InlineData("🧍🏽‍♂️", "%F0%9F%A7%8D%F0%9F%8F%BD%E2%80%8D%E2%99%82%EF%B8%8F")]
        public void Given_PathParameterContainingNonSpecifiedCharacters_When_Building_Then_ReplacedWithPercentEncoded(string unencoded, string encoded) {
            var builder = new WebRequestPathBuilder(baseUrl, path);

            var pathParameters = new Dictionary<string, string> {
                { "UrlParam", unencoded }
            };

            builder.AddPathParameters(pathParameters);

            Assert.Equal($"https://api.xero.com/api.xro/2.0/Foo/{encoded}", builder.GetFullUri());
        }

        [Fact]
        public void Given_PathParameterContainingPercent_When_Building_Then_ReplacedWithPercentEncoded() {
            var builder = new WebRequestPathBuilder(baseUrl, path);

            var pathParameters = new Dictionary<string, string> {
                { "UrlParam", "%" }
            };

            builder.AddPathParameters(pathParameters);

            Assert.Equal("https://api.xero.com/api.xro/2.0/Foo/%25", builder.GetFullUri());
        }

        /// <summary>
        /// Xero API does not support the plus sign (+) when encoding spaces.
        ///
        /// See https://github.com/XeroAPI/Xero-NetStandard/issues/570
        /// </summary>
        [Fact]
        public void Given_PathParameterContainingSpace_When_Building_Then_ReplacedWithPercent20_Because_PlusSignIsNotSupported() {
            var builder = new WebRequestPathBuilder(baseUrl, path);

            var pathParameters = new Dictionary<string, string> {
                { "UrlParam", "foo bar" }
            };

            builder.AddPathParameters(pathParameters);

            Assert.Equal("https://api.xero.com/api.xro/2.0/Foo/foo%20bar", builder.GetFullUri());
        }

        [Fact]
        public void Given_PathParameterWithoutSubstitution_When_Building_Then_NotReplaced() {
            var builder = new WebRequestPathBuilder(baseUrl, path);

            builder.AddPathParameters(new Dictionary<string, string>());

            Assert.Equal("https://api.xero.com/api.xro/2.0/Foo/{UrlParam}", builder.GetFullUri());
        }

        [Fact]
        public void Given_PathParameterReferencedMultipleTimes_When_Building_Then_ReplacedWithSameValue() {
            var builder = new WebRequestPathBuilder(baseUrl, "/Foo/{UrlParam}/Bar/{UrlParam}");

            var pathParameters = new Dictionary<string, string> {
                { "UrlParam", "value" }
            };

            builder.AddPathParameters(pathParameters);

            Assert.Equal("https://api.xero.com/api.xro/2.0/Foo/value/Bar/value", builder.GetFullUri());
        }
    }
}
