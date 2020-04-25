using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace PassGenerator.DomainModel
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    public class PassGenerator
    {
        private readonly Random _random = new Random();

        public readonly string UpperAlphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public readonly string LowerAlphabets = "abcdefghijklmnopqrstuvwxyz";
        public readonly string Numbers = "0123456789";
        public readonly string Marks = "!@#$%^&*";

        public string Generate(
            int length,
            bool isUpperAlphabet,
            bool isLowerAlphabet,
            bool isNumber,
            bool isMark)
        {

            var candidateSb = new StringBuilder();

            if (isUpperAlphabet) candidateSb.Append(UpperAlphabets);
            if (isLowerAlphabet) candidateSb.Append(LowerAlphabets);
            if (isNumber) candidateSb.Append(Numbers);
            if (isMark) candidateSb.Append(Marks);

            var candidates = candidateSb.ToString();

            if (candidates.Length == 0)
                return "";

            var resultSb = new StringBuilder();

            for (var i = 0; i != length; ++i)
            {
                var index = _random.Next(candidates.Length);

                resultSb.Append(candidates[index]);
            }

            return resultSb.ToString();
        }
    }
}