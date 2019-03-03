using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PostMortem.Markdown
{
    public static class MarkdownStringExtensions
    {
        public static string MakeEmphasis(this string content) => $"*{content}*";

        public static string MakeStrongEmphasis(this string content) => $"**{content}**";

        public static string MakeCombinedEmphasis(this string content) => $"**{content}_**";

        public static string MakeStrikethrough(this string content) => $"~~{content}~~";

        public static string MakeInlineCode(this string content) => $"``{content}``"; // double back tick for escaping back ticks

        public static string MakeCodeBlock(this string content, string language) =>
            $"```{language}{Environment.NewLine}{content}{Environment.NewLine}```";
    }

    public class MarkdownDocument
    {
        protected readonly StringBuilder Document;

        public MarkdownDocument()
        {
            this.Document = new StringBuilder();
        }

        // Text
        public virtual void WriteLine(string content) => this.Document.AppendLine(content);
        public virtual void Write(string content) => this.Document.Append(content);

        // Headers
        public virtual void WriteHeader1(string content) => this.Document.AppendLine($"# {content}");
        public virtual void WriteHeader2(string content) => this.Document.AppendLine($"## {content}");
        public virtual void WriteHeader3(string content) => this.Document.AppendLine($"### {content}");
        public virtual void WriteHeader4(string content) => this.Document.AppendLine($"#### {content}");
        public virtual void WriteHeader5(string content) => this.Document.AppendLine($"##### {content}");
        public virtual void WriteHeader6(string content) => this.Document.AppendLine($"###### {content}");

        // Emphasis
        public virtual void WriteEmphasis(string content) => this.Document.Append(content.MakeEmphasis());
        public virtual void WriteStrongEmphasis(string content) => this.Document.Append(content.MakeStrongEmphasis());
        public virtual void WriteCombinedEmphasis(string content) => this.Document.Append(content.MakeCombinedEmphasis());
        public virtual void WriteStrikethrough(string content) => this.Document.Append(content.MakeStrikethrough());

        // Tables
        public virtual void WriteTable<T>(T data, string[] headers, params Func<T, string>[] selectors)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));
            if (headers == null) throw new ArgumentNullException(nameof(headers));
            if (selectors == null) throw new ArgumentNullException(nameof(selectors));
            if (selectors.Length == 0)
                throw new ArgumentException("Value cannot be an empty collection.", nameof(selectors));

            WriteTableHeader(headers);
            WriteTableRow(data, selectors);

            this.Document.Append($"|{Environment.NewLine}");
        }

        public virtual void WriteTable<T>(IEnumerable<T> data, string[] headers, params Func<T, string>[] selectors)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));
            if (headers == null) throw new ArgumentNullException(nameof(headers));
            if (selectors == null) throw new ArgumentNullException(nameof(selectors));
            if (selectors.Length == 0)
                throw new ArgumentException("Value cannot be an empty collection.", nameof(selectors));

            this.WriteTableHeader(headers);
            foreach (var entry in data)
            {
                this.WriteTableRow(entry, selectors);
            }
        }

        private void WriteTableRow<T>(T data, IEnumerable<Func<T, string>> selectors)
        {
            foreach (var selector in selectors)
            {
                this.Document.Append("|");
                this.Document.Append(selector.Invoke(data));
            }
            this.Document.AppendLine();
        }

        private void WriteTableHeader(string[] headers)
        {
            this.Document.AppendLine(string.Join("|", headers));
            for (var i = 0; i < headers.Length; i++)
            {
                this.Document.Append("|:---");
            }
            this.Document.Append($"|{Environment.NewLine}");
        }

        // Lists
        public virtual void WriteUnorderedList(IEnumerable<string> data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));

            foreach (var entry in data)
            {
                this.Document.AppendLine($"* {entry}");
            }
        }

        public virtual void WriteOrderedList(IEnumerable<string> data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));

            var res = data.Select((s, i) => $"{i+1}. {s}").ToList();
            res.ForEach(s => this.Document.AppendLine(s));
        }

        // Magic shizzle
        public string GetString() => this.Document.ToString();
    }
}
