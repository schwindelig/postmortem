using System.Text;

namespace PostMortem.Markdown
{
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
        public virtual void WriteEmphasis(string content) => this.Document.Append($"*{content}*");
        public virtual void WriteStrongEmphasis(string content) => this.Document.Append($"**{content}**");
        public virtual void WriteCombinedEmphasis(string content) => this.Document.Append($"**{content}_**");
        public virtual void WriteStrikethrough(string content) => this.Document.Append($"~~{content}~~");
    }
}
