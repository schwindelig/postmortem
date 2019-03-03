using System;
using System.IO;
using Markdig;
using Newtonsoft.Json;
using PostMortem.Core.Exceptions;
using PostMortem.Markdown;
using Serilog;

namespace PostMortem.Core.Export
{
    public class Exporter
    {
        public void ExportJson(object data, string path)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(path));

            Log.Verbose("Exporting data as JSON to {path}", path);

            if (File.Exists(path))
            {
                throw new FileAlreadyExistsException($"File at {path} already exists");
            }

            using (TextWriter textWriter = File.CreateText(path))
            {
                var serializer = new JsonSerializer();
                serializer.Serialize(textWriter, data);
                textWriter.Flush();
            }
        }

        public void ExportFile(string data, string path)
        {
            if (string.IsNullOrWhiteSpace(data))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(data));
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(path));

            Log.Verbose("Exporting data to {path}", path);

            if (File.Exists(path))
            {
                throw new FileAlreadyExistsException($"File at {path} already exists");
            }

            File.WriteAllText(path, data);
        }

        public void ExportHtml(MarkdownDocument document, string path)
        {
            if (document == null) throw new ArgumentNullException(nameof(document));
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(path));

            Log.Verbose($"Exporting markdown as HTML to {path}");

            if (File.Exists(path))
            {
                throw new FileAlreadyExistsException($"File at {path} already exists");
            }

            var pipeline = new MarkdownPipelineBuilder()
                .UseAdvancedExtensions()
                .UseBootstrap()
                .Build();

            var bodyHtml = Markdig.Markdown.ToHtml(document.GetString(), pipeline);
            var styleSheetUrl = this.GetStylesheetUrl();
            var html = this.MergeWithHtmlDocument(bodyHtml, styleSheetUrl);
            File.WriteAllText(path, html);
        }

        protected virtual string MergeWithHtmlDocument(string body, string styleSheetUrl)
        {
            // I am very proud of this method. Probably one of the best I have ever written.
            // At least it's marked as virtual, lol.
            return $@"<!doctype html>
                        <html lang=""en"">
                          <head>
                            <!-- Required meta tags -->
                            <meta charset=""utf-8"">
                            <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">

                            <!-- Bootstrap CSS -->
                            <link rel=""stylesheet"" href=""{styleSheetUrl}"" crossorigin=""anonymous"">

                            <title>Hello, world!</title>
                          </head>
                          <body style=""margin:2em;"">
                            {body}

                            <!-- Optional JavaScript -->
                            <!-- jQuery first, then Popper.js, then Bootstrap JS -->
                            <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
                            <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"" integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1"" crossorigin=""anonymous""></script>
                            <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"" integrity=""sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM"" crossorigin=""anonymous""></script>
                          </body>
                        </html>";
        }

        protected virtual string GetStylesheetUrl()
        {
            // return "https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"; // default
            // return "https://stackpath.bootstrapcdn.com/bootswatch/4.3.1/slate/bootstrap.min.css"; // slate
            // return "https://stackpath.bootstrapcdn.com/bootswatch/4.3.1/sandstone/bootstrap.min.css"; // sandstone
            // return "https://stackpath.bootstrapcdn.com/bootswatch/4.3.1/litera/bootstrap.min.css"; // litera
            // return "https://stackpath.bootstrapcdn.com/bootswatch/4.3.1/flatly/bootstrap.min.css"; // flatly
            // return "https://stackpath.bootstrapcdn.com/bootswatch/4.3.1/darkly/bootstrap.min.css"; // darkly
            // return "https://stackpath.bootstrapcdn.com/bootswatch/4.3.1/cyborg/bootstrap.min.css"; // cyborg

            return "https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"; // default
        }
    }
}
