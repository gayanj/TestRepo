using System.Text;

namespace Msftlayer
{
    public class ClWordParser
    {
        //word parser
        public string Convertwordtotext(string docfilepath)
        {
            return null;
            /*
            Microsoft.Office.Interop.Word.Application mywordapp = new Microsoft.Office.Interop.Word.Application();

            object file = docfilepath;

            object nullrefs = System.Reflection.Missing.Value;

            Microsoft.Office.Interop.Word.Document odoc = mywordapp.Documents.Open(ref file, ref nullrefs, ref nullrefs, ref nullrefs, ref nullrefs, ref nullrefs, ref nullrefs, ref nullrefs, ref nullrefs, ref nullrefs, ref nullrefs, ref nullrefs);

            Microsoft.Office.Interop.Word.Document doc1 = mywordapp.ActiveDocument;

            string doc_content = odoc.Content.Text;

            odoc.Close(ref nullrefs, ref nullrefs, ref nullrefs);

            return doc_content;
            */
        }

        //encoding converter
        private string Chgencode(string str1)
        {
            Encoding ascii = Encoding.ASCII;
            Encoding unicode = Encoding.Unicode;

            // Convert the string into a byte[].
            byte[] unicodeBytes = unicode.GetBytes(str1);

            // Perform the conversion from one encoding to the other.
            byte[] asciiBytes = Encoding.Convert(unicode, ascii, unicodeBytes);

            // Convert the new byte[] into a char[] and then into a string.
            // This is a slightly different approach to converting to illustrate
            // the use of GetCharCount/GetChars.
            var asciiChars = new char[ascii.GetCharCount(asciiBytes, 0, asciiBytes.Length)];
            ascii.GetChars(asciiBytes, 0, asciiBytes.Length, asciiChars, 0);
            var asciiString = new string(asciiChars);

            // Display the strings created before and after the conversion.
            return asciiString;
        }
    }
}