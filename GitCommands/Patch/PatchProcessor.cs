using System.Text.RegularExpressions;
        public List<Patch> CreatePatchesFromString(String patchText)
            string[] lines = patchText.Split('\n');
            for(int i = 0; i < lines.Length; i++)
                input = lines[i];
                    patch.AppendText(input);
                    if (i < lines.Length - 1)
                        patch.AppendText("\n");
                    Match regexMatch = Regex.Match(input, "[-]{3}[ ][\\\"]{0,1}[aiwco12]/(.*)[\\\"]{0,1}");
                    Match regexMatch = Regex.Match(input, "[+]{3}[ ][\\\"]{0,1}[biwco12]/(.*)[\\\"]{0,1}");
                if (input.StartsWithAny(new string[] { " ", "-", "+", "@" }))
                    //diff content
                    input = GitCommandHelpers.ReEncodeStringFromLossless(input, FilesContentEncoding);
                else
                    //warnings, messages ...
                    input = GitCommandHelpers.ReEncodeStringFromLossless(input, Settings.SystemEncoding);                    
                                      "[ ][\\\"]{0,1}[aiwco12]/(.*)[\\\"]{0,1}[ ][\\\"]{0,1}[biwco12]/(.*)[\\\"]{0,1}");
            patch.FileNameA = match.Groups[1].Value.Trim();
            patch.FileNameB = match.Groups[2].Value.Trim();