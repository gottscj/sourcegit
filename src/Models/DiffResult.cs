using Avalonia.Media.Imaging;

namespace SourceGit.Models
{
    public enum TextDiffLineType
    {
    public class TextInlineRange
    {
    public class TextDiffLine
    {
        public TextDiffLine(TextDiffLineType type, string content, int oldLine, int newLine)
        {
    public class TextDiffSelection
    {
        public bool IsInRange(int idx)
        {
    public partial class TextDiff
    {
        public void GenerateNewPatchFromSelection(Change change, string fileBlobGuid, TextDiffSelection selection, bool revert, string output)
        {
            if (!revert && !isTracked)
                builder.Append("new file mode 100644\n");
            if (selection.StartLine != 1)
                additions++;
            if (revert)
            {
                for (int i = 1; i <= totalLines; i++)
                {
                    if (line.Type != TextDiffLineType.Added)
                        continue;
            }
            else
            {
                for (int i = selection.StartLine - 1; i < selection.EndLine; i++)
                {
                    if (line.Type != TextDiffLineType.Added)
                        continue;
        public void GeneratePatchFromSelection(Change change, string fileTreeGuid, TextDiffSelection selection, bool revert, string output)
        {
            if (selection.EndLine < Lines.Count)
            {
                if (lastLine.Type == TextDiffLineType.Added || lastLine.Type == TextDiffLineType.Deleted)
                {
                    for (int i = selection.EndLine; i < Lines.Count; i++)
                    {
                        if (line.Type == TextDiffLineType.Indicator)
                            break;
                        if (revert)
                        {
                            if (line.Type == TextDiffLineType.Normal || line.Type == TextDiffLineType.Added)
                            {
                        }
                        else
                        {
                            if (line.Type == TextDiffLineType.Normal || line.Type == TextDiffLineType.Deleted)
                            {
            if (Lines[selection.StartLine - 1].Type != TextDiffLineType.Indicator)
            {
                for (int i = selection.StartLine - 2; i >= 0; i--)
                {
                    if (line.Type == TextDiffLineType.Indicator)
                    {
                for (int i = 0; i < indicator; i++)
                {
                    if (line.Type == TextDiffLineType.Added)
                    {
                    }
                    else if (line.Type == TextDiffLineType.Deleted)
                    {
                for (int i = indicator; i < selection.StartLine - 1; i++)
                {
                    if (line.Type == TextDiffLineType.Indicator)
                    {
                    }
                    else if (line.Type == TextDiffLineType.Added)
                    {
                        if (revert)
                            builder.Append("\n ").Append(line.Content);
                    }
                    else if (line.Type == TextDiffLineType.Deleted)
                    {
                        if (!revert)
                            builder.Append("\n ").Append(line.Content);
                    }
                    else if (line.Type == TextDiffLineType.Normal)
                    {
            for (int i = selection.StartLine - 1; i < selection.EndLine; i++)
            {
                if (line.Type == TextDiffLineType.Indicator)
                {
                    if (!ProcessIndicatorForPatch(builder, line, i, selection.StartLine, selection.EndLine, selection.IgnoredDeletes, selection.IgnoredAdds, revert, tail != null))
                    {
                }
                else if (line.Type == TextDiffLineType.Normal)
                {
                }
                else if (line.Type == TextDiffLineType.Added)
                {
                }
                else if (line.Type == TextDiffLineType.Deleted)
                {
        public void GeneratePatchFromSelectionSingleSide(Change change, string fileTreeGuid, TextDiffSelection selection, bool revert, bool isOldSide, string output)
        {
            if (selection.EndLine < Lines.Count)
            {
                if (lastLine.Type == TextDiffLineType.Added || lastLine.Type == TextDiffLineType.Deleted)
                {
                    for (int i = selection.EndLine; i < Lines.Count; i++)
                    {
                        if (line.Type == TextDiffLineType.Indicator)
                            break;
                        if (revert)
                        {
                            if (line.Type == TextDiffLineType.Normal || line.Type == TextDiffLineType.Added)
                            {
                        }
                        else
                        {
                            if (line.Type == TextDiffLineType.Normal || line.Type == TextDiffLineType.Deleted)
                            {
            if (Lines[selection.StartLine - 1].Type != TextDiffLineType.Indicator)
            {
                for (int i = selection.StartLine - 2; i >= 0; i--)
                {
                    if (line.Type == TextDiffLineType.Indicator)
                    {
                for (int i = 0; i < indicator; i++)
                {
                    if (line.Type == TextDiffLineType.Added)
                    {
                    }
                    else if (line.Type == TextDiffLineType.Deleted)
                    {
                for (int i = indicator; i < selection.StartLine - 1; i++)
                {
                    if (line.Type == TextDiffLineType.Indicator)
                    {
                    }
                    else if (line.Type == TextDiffLineType.Added)
                    {
                        if (revert)
                            builder.Append("\n ").Append(line.Content);
                    }
                    else if (line.Type == TextDiffLineType.Deleted)
                    {
                        if (!revert)
                            builder.Append("\n ").Append(line.Content);
                    }
                    else if (line.Type == TextDiffLineType.Normal)
                    {
            for (int i = selection.StartLine - 1; i < selection.EndLine; i++)
            {
                if (line.Type == TextDiffLineType.Indicator)
                {
                    if (!ProcessIndicatorForPatchSingleSide(builder, line, i, selection.StartLine, selection.EndLine, selection.IgnoredDeletes, selection.IgnoredAdds, revert, isOldSide, tail != null))
                    {
                }
                else if (line.Type == TextDiffLineType.Normal)
                {
                }
                else if (line.Type == TextDiffLineType.Added)
                {
                    if (isOldSide)
                    {
                        if (revert)
                        {
                        }
                        else
                        {
                    }
                    else
                    {
                }
                else if (line.Type == TextDiffLineType.Deleted)
                {
                    if (isOldSide)
                    {
                    }
                    else
                    {
                        if (!revert)
                        {
                        }
                        else
                        {
        [GeneratedRegex(@"^@@ \-(\d+),?\d* \+(\d+),?\d* @@")]
        private static partial Regex indicatorRegex();
        private bool ProcessIndicatorForPatch(StringBuilder builder, TextDiffLine indicator, int idx, int start, int end, int ignoreRemoves, int ignoreAdds, bool revert, bool tailed)
        {
            var match = indicatorRegex().Match(indicator.Content);
            for (int i = idx + 1; i < end; i++)
            {
                if (test.Type == TextDiffLineType.Indicator)
                    break;
                if (test.Type == TextDiffLineType.Normal)
                {
                }
                else if (test.Type == TextDiffLineType.Added)
                {
                    if (i < start - 1)
                    {
                        if (revert)
                        {
                    }
                    else
                    {
                    if (i == end - 1 && tailed)
                    {
                }
                else if (test.Type == TextDiffLineType.Deleted)
                {
                    if (i < start - 1)
                    {
                        if (!revert)
                        {
                    }
                    else
                    {
                    if (i == end - 1 && tailed)
                    {
            if (oldCount == 0 && newCount == 0)
                return false;
        private bool ProcessIndicatorForPatchSingleSide(StringBuilder builder, TextDiffLine indicator, int idx, int start, int end, int ignoreRemoves, int ignoreAdds, bool revert, bool isOldSide, bool tailed)
        {
            var match = indicatorRegex().Match(indicator.Content);
            for (int i = idx + 1; i < end; i++)
            {
                if (test.Type == TextDiffLineType.Indicator)
                    break;
                if (test.Type == TextDiffLineType.Normal)
                {
                }
                else if (test.Type == TextDiffLineType.Added)
                {
                    if (i < start - 1)
                    {
                        if (revert)
                        {
                    }
                    else
                    {
                        if (isOldSide)
                        {
                            if (revert)
                            {
                        }
                        else
                        {
                    if (i == end - 1 && tailed)
                    {
                }
                else if (test.Type == TextDiffLineType.Deleted)
                {
                    if (i < start - 1)
                    {
                        if (!revert)
                        {
                    }
                    else
                    {
                        if (isOldSide)
                        {
                        }
                        else
                        {
                            if (!revert)
                            {
                    if (i == end - 1 && tailed)
                    {
            if (oldCount == 0 && newCount == 0)
                return false;
    public class LFSDiff
    {
    public class BinaryDiff
    {
    public class ImageDiff
    {
        public Bitmap Old { get; set; } = null;
        public Bitmap New { get; set; } = null;

        public string OldSize => Old != null ? $"{Old.PixelSize.Width} x {Old.PixelSize.Height}" : "0 x 0";
        public string NewSize => New != null ? $"{New.PixelSize.Width} x {New.PixelSize.Height}" : "0 x 0";
    }

    public class NoOrEOLChange
    {
    }

    public class DiffResult
    {