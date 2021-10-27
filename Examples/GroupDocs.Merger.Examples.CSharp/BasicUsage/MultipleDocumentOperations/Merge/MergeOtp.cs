using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple OTP files into single file.
    /// For more details about merging Origin Graph Template (.otp) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/otp
    /// </summary>
    internal static class MergeOtp
    {
        public static void Run()
        {            
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.otp");
            
            // Load the source OTP file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_OTP))
            {
                // Add another OTP file to merge
                merger.Join(Constants.SAMPLE_OTP_2);
                // Merge OTP files ans save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nOTP files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            