using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Text.RegularExpressions;
using Memorylayer;
using System.Collections;

namespace Msftlayer
{
    public class ClTranslator
    {
        //private string GetNumberClean(string astr)
        //{
        //    var atemp = astr;
        //    atemp = atemp.Replace("0", "");
        //    atemp = atemp.Replace("1", "");
        //    atemp = atemp.Replace("2", "");
        //    atemp = atemp.Replace("3", "");
        //    atemp = atemp.Replace("4", "");
        //    atemp = atemp.Replace("5", "");
        //    atemp = atemp.Replace("6", "");
        //    atemp = atemp.Replace("7", "");
        //    atemp = atemp.Replace("8", "");
        //    atemp = atemp.Replace("9", "");
        //    return atemp;
        //}

        public ArrayList GetMlData()
        {
            var iclass = new MlTranslator();
            return (ArrayList)iclass.Getdata();
        }

        public string InvokePy(string astr, ArrayList al)
        {

            //ArrayList tarra = (ArrayList)iclass.Getdata("a");
            //ArrayList tarrb = (ArrayList)iclass.Getdata("b");
            //ArrayList tarrc = (ArrayList)iclass.Getdata("c");
            //ArrayList tarrd = (ArrayList)iclass.Getdata("d");
            //ArrayList tarre = (ArrayList)iclass.Getdata("e");
            //ArrayList tarrf = (ArrayList)iclass.Getdata("f");
            //ArrayList tarrg = (ArrayList)iclass.Getdata("g");
            //ArrayList tarrh = (ArrayList)iclass.Getdata("h");
            //ArrayList tarri = (ArrayList)iclass.Getdata("i");
            //ArrayList tarrj = (ArrayList)iclass.Getdata("j");
            //ArrayList tarrk = (ArrayList)iclass.Getdata("k");
            //ArrayList tarrl = (ArrayList)iclass.Getdata("l");
            //ArrayList tarrm = (ArrayList)iclass.Getdata("m");
            //ArrayList tarrn = (ArrayList)iclass.Getdata("n");
            //ArrayList tarro = (ArrayList)iclass.Getdata("o");
            //ArrayList tarrp = (ArrayList)iclass.Getdata("p");
            //ArrayList tarrq = (ArrayList)iclass.Getdata("q");
            //ArrayList tarrr = (ArrayList)iclass.Getdata("r");
            //ArrayList tarrs = (ArrayList)iclass.Getdata("s");
            //ArrayList tarrt = (ArrayList)iclass.Getdata("t");
            //ArrayList tarru = (ArrayList)iclass.Getdata("u");
            //ArrayList tarrv = (ArrayList)iclass.Getdata("v");
            //ArrayList tarrw = (ArrayList)iclass.Getdata("w");
            //ArrayList tarrx = (ArrayList)iclass.Getdata("x");
            //ArrayList tarry = (ArrayList)iclass.Getdata("y");
            //ArrayList tarrz = (ArrayList)iclass.Getdata("z");

            //ArrayList tarr = new ArrayList();
            //tarr = (ArrayList)iclass.Getdata();

            //if (astr.StartsWith("a") || astr.StartsWith("A")) { tarr = tarra; }
            //else if (astr.StartsWith("b") || astr.StartsWith("B")) { tarr = tarrb; }
            //else if (astr.StartsWith("c") || astr.StartsWith("C")) { tarr = tarrc; }
            //else if (astr.StartsWith("d") || astr.StartsWith("D")) { tarr = tarrd; }
            //else if (astr.StartsWith("e") || astr.StartsWith("E")) { tarr = tarre; }
            //else if (astr.StartsWith("f") || astr.StartsWith("F")) { tarr = tarrf; }
            //else if (astr.StartsWith("g") || astr.StartsWith("G")) { tarr = tarrg; }
            //else if (astr.StartsWith("h") || astr.StartsWith("H")) { tarr = tarrh; }
            //else if (astr.StartsWith("i") || astr.StartsWith("I")) { tarr = tarri; }
            //else if (astr.StartsWith("j") || astr.StartsWith("J")) { tarr = tarrj; }
            //else if (astr.StartsWith("k") || astr.StartsWith("K")) { tarr = tarrk; }
            //else if (astr.StartsWith("l") || astr.StartsWith("L")) { tarr = tarrl; }
            //else if (astr.StartsWith("m") || astr.StartsWith("M")) { tarr = tarrm; }
            //else if (astr.StartsWith("n") || astr.StartsWith("N")) { tarr = tarrn; }
            //else if (astr.StartsWith("o") || astr.StartsWith("O")) { tarr = tarro; }
            //else if (astr.StartsWith("p") || astr.StartsWith("P")) { tarr = tarrp; }
            //else if (astr.StartsWith("q") || astr.StartsWith("Q")) { tarr = tarrq; }
            //else if (astr.StartsWith("r") || astr.StartsWith("R")) { tarr = tarrr; }
            //else if (astr.StartsWith("s") || astr.StartsWith("S")) { tarr = tarrs; }
            //else if (astr.StartsWith("t") || astr.StartsWith("T")) { tarr = tarrt; }
            //else if (astr.StartsWith("u") || astr.StartsWith("U")) { tarr = tarru; }
            //else if (astr.StartsWith("v") || astr.StartsWith("V")) { tarr = tarrv; }
            //else if (astr.StartsWith("w") || astr.StartsWith("W")) { tarr = tarrw; }
            //else if (astr.StartsWith("x") || astr.StartsWith("X")) { tarr = tarrx; }
            //else if (astr.StartsWith("y") || astr.StartsWith("Y")) { tarr = tarry; }
            //else if (astr.StartsWith("z") || astr.StartsWith("Z")) { tarr = tarrz; }
            //else { }

            //tarr.TrimToSize();            

            //int indx = tarr.BinarySearch(astr.ToLowerInvariant());

            //if (indx > 0)
            //{
            //    string acleanstr = tarr[indx - 1].ToString();
            //    tarr.Clear();
            //    return acleanstr;
            //}




            //for (var ind = 0; ind < tarr.Count; ind++)
            //{
            //    if (tarr[ind].ToString().ToLowerInvariant() == astr.ToLowerInvariant())
            //    {
            //        string acleanstr = tarr[ind - 1].ToString();
            //        tarr.Clear();
            //        return acleanstr;
            //    }
            //}

            //python replacement for above
            var ipy = IronPython.Hosting.Python.CreateRuntime();
            dynamic first = ipy.UseFile("C:\\stable0.5\\msftlayer\\msftlayer\\Translator.py");
            return first.Processmatch(astr, al);

            //tarr.Clear();
            return astr;
        }

        //public string Getcheckexistingrecord(string astr)
        //{
        //    var iclass = new MlTranslator();
        //    return iclass.Getcheckexistingrecord(astr);
        //}

        public string Getsplitedstring(string astr)
        {
            var iclass = new MlTranslator();
            string[] terminator = { "itranslation" };
            string[] arr = astr.Split(terminator, StringSplitOptions.None);
            string sb = string.Empty;

            for (int ci = 0; ci < arr.Length; ci++) //string ci in arr)
            {
                if (arr[ci].Contains("0x100fea"))
                {
                    string si = arr[ci].Replace("<", " <");
                    si = si.Replace(">", "> ");

                    char[] terminator1 = { ' ' };
                    string[] arr2 = si.Split(terminator1, StringSplitOptions.None);

                    for (int si2 = 0; si2 < arr2.Length; si2++)//string si2 in arr2)
                    {
                        if (arr2[si2].Contains(">") || arr2[si2].Contains("<") || arr2[si2].Contains("/") || arr2[si2] == "" ||
                            arr2[si2].Contains("\"") || arr2[si2].Contains("mouseover") || arr2[si2].Contains("class")
                            || arr2[si2].Contains("[") || arr2[si2].Contains("&") || arr2[si2].Contains(",") || arr2[si2].Contains("px")
                             || arr2[si2].Contains("0x100fea")
                            )
                        {
                            sb += " " + arr2[si2];
                        }

                        else
                        {
                            //check for fast cache.

                            //else add to fast cache.
                            //var tempholder = InvokePy(arr2[si2], (ArrayList)iclass.Getdata());
                            var ipy = IronPython.Hosting.Python.CreateRuntime();
                            dynamic first = ipy.UseFile("C:\\stable0.5\\msftlayer\\msftlayer\\Translator.py");
                            ArrayList alisi = (ArrayList)iclass.Getdata();
                            sb += first.Lowerimp(arr2[si2], alisi);                            
                            alisi.Clear();

                            //if (tempholder == null)
                            //{
                            //    sb += arr2[si2] + " ";
                            //    //add to dictionary for lookup in future.
                            //    //if (Getcheckexistingrecord(si) == null && GetNumberClean(si) != "")
                            //    //{
                            //    //    //InsertNewWords(si);
                            //    //}
                            //}

                            //else
                            //{
                            //    //add to fast cache here
                            //    sb += " " + tempholder + " ";
                            //}
                        }
                    }
                }

                else
                {
                    sb = sb + " " + arr[ci];
                }
            }

            return sb;
        }


        //uncomment the above in terms of failure

        //public string Getsplitedstring(string astr)
        //{
        //    var iclass = new MlTranslator();

        //    var ipy = IronPython.Hosting.Python.CreateRuntime();
        //    dynamic first = ipy.UseFile("C:\\stable0.5\\msftlayer\\msftlayer\\Translator.py");
        //    ArrayList al1 = (ArrayList)iclass.Getdata();
        //    string aa =  first.Highlevelparser(astr, al1);

        //    //tarr.Clear();
        //    return aa;
        //}

        // public string GetClean(string astr)
        // {
        //var atemp = astr.Replace("'", "");
        /*
        atemp = atemp.Replace("\"","");
        atemp = atemp.Replace(",", "");
        atemp = atemp.Replace(".", "");
        atemp = atemp.Replace("@", "");
        atemp = atemp.Replace("+", "");
        atemp = atemp.Replace("$", "");
        atemp = atemp.Replace("-", "");
        atemp = atemp.Replace("\'", "");
        atemp = atemp.Replace("*", "");
        atemp = atemp.Replace("'", "");
        atemp = atemp.Replace("(", "");
        atemp = atemp.Replace("\r\n", "");
        atemp = atemp.Replace("^", "");
        atemp = atemp.Replace("%", "");
        atemp = atemp.Replace("!", "");
        atemp = atemp.Replace(")", "");
        atemp = atemp.Replace("[", "");
        atemp = atemp.Replace("]", "");
        atemp = atemp.Replace("~", "");
        atemp = atemp.Replace("+", "");
        atemp = atemp.Replace("_", "");
        atemp = atemp.Replace("/", "");
        atemp = atemp.Replace("?", "");
        atemp = atemp.Replace("|", "");
        atemp = atemp.Replace("&", " and ");
        atemp = atemp.Replace("<", "");
        atemp = atemp.Replace(">", "");
        atemp = atemp.Replace(":", "");
        atemp = atemp.Replace(";", "");
        atemp = atemp.Replace("—", "");  
        atemp = Regex.Replace(atemp, @"<[^>]*>", "");
       */

        //    return atemp;
        //}
    }
}