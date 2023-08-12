using Shared.Enums;

namespace Shared.Extensions
{
    public static class StringExtensions
    {
        public static string ToBold(this string text)
        {
            return $"<b>{text}</b>";
        }

        public static string ToItalic(this string text)
        {
            return $"<i>{text}</i>";
        }

        public static string ToUnderline(this string text)
        {
            return $"<u>{text}</u>";
        }

        public static string ToStrikethrough(this string text)
        {
            return $"<s>{text}</s>";
        }

        public static string ToMonospace(this string text)
        {
            return $"<code>{text}</code>";
        }

        public static string ToPreformatted(this string text)
        {
            return $"<pre>{text}</pre>";
        }

        public static string WrapWithTag(this string text, TelegramHtmlTags tag)
        {
            if (tag == TelegramHtmlTags.Bold)
                return ToBold(text);

            if (tag == TelegramHtmlTags.Italic)
                return ToItalic(text);

            if (tag == TelegramHtmlTags.Underline)
                return ToUnderline(text);

            if (tag == TelegramHtmlTags.Strikethrough)
                return ToStrikethrough(text);

            if (tag == TelegramHtmlTags.Monospace)
                return ToMonospace(text);

            if (tag == TelegramHtmlTags.Preformatted)
                return ToPreformatted(text);

            return text;
        }

        public static string WrapWithTags(this string text, IEnumerable<TelegramHtmlTags> tags)
        {
            if (!tags.Any())
                return text;

            var resultText = text;

            foreach (var tag in tags)
            {
                resultText = resultText.WrapWithTag(tag);
            }

            return resultText;
        }

        public static string WrapWithTags(this string text, int mask)
        {
            return text.WrapWithTags(mask.ToTelegramHtmlTags());
        }

        private static IEnumerable<TelegramHtmlTags> ToTelegramHtmlTags(this int mask)
        {
            var flags = new List<TelegramHtmlTags>();

            foreach (TelegramHtmlTags tag in Enum.GetValues(typeof(TelegramHtmlTags)))
            {
                if ((mask & (int)tag) == (int)tag)
                {
                    flags.Add(tag);
                }
            }

            return flags;
        }
    }
}
