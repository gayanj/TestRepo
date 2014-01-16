using System;
using Msftlayer;
using System.IO;
using System.Text;

namespace JB.Jobseekers.ResumeBuilder
{
    public partial class ResFromURL : ClCookie
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Isuserloginvalid();
            ResResumeLink.Focus();
            Page.Form.DefaultButton = ButtonResume.UniqueID;
        }

        private string GetGuid()
        {
            return Guid.NewGuid().ToString();
        }

        private string parseresume(string _tempstore)
        {
            //process text
            string[] _splitoptions = { "\n", "\r", "\a", "\t" };
            string[] _mainarray = _tempstore.Split(_splitoptions, StringSplitOptions.RemoveEmptyEntries);

            //marker legend
            //index 0 = Profile at index
            //index 1 = Education at index
            //index 3 = Experience at index
            //index 4 = Skills at index

            var _markers = new int[4];

            //these flags below are necessary to avoid next item
            //and to save us from looping into for again and 
            //again.

            int[] flags = { 0, 0, 0, 0 };

            //first we find sections.
            for (int i = 0; i < _mainarray.Length; i++)
            {
                if (_mainarray[i].Contains("summary") || _mainarray[i].Contains("goal") ||
                    _mainarray[i].Contains("objective") || _mainarray[i].Contains("profile"))
                {
                    if (flags[0] == 0)
                    {
                        //found profile
                        _markers[0] = i;
                        flags[0] = 1;
                    }
                }

                else if (_mainarray[i].Contains("education") || _mainarray[i].Contains("schooling") ||
                         _mainarray[i].Contains("educational"))
                {
                    if (flags[1] == 0)
                    {
                        //found education
                        _markers[1] = i;
                        flags[1] = 1;
                    }
                }

                else if (_mainarray[i].Contains("experience") || _mainarray[i].Contains("accomplishment"))
                {
                    if (flags[2] == 0)
                    {
                        //found experience
                        _markers[2] = i;
                        flags[2] = 1;
                    }
                }

                else if (_mainarray[i].Contains("skill") || _mainarray[i].Contains("competencies"))
                {
                    if (flags[3] == 0)
                    {
                        //found skills
                        _markers[3] = i;
                        flags[3] = 1;
                    }
                }

                else
                {
                    return "Non Standard Resume";
                }
            }

            //sort them
            Array.Sort(_markers);

            var _output = new StringBuilder();
            var _mark = "";

            if (_mainarray.Length > 4)
            {
                _mark += _mainarray[_markers[0]];
                _output.Append(_mark);

                string maxid = GetGuid();
                int j = 0;

                for (j = _markers[0]; j < _markers[1]; j++)
                {
                    if (_mark != "")
                    {
                        _output.Append(_mainarray[j]);
                        //_datah.InsertData(maxid, _mark, _mainarray[j]);
                    }
                }

                _mark = "";
                _mark += _mainarray[_markers[1]];
                _output.Append(_mark);

                for (j = _markers[1]; j < _markers[2]; j++)
                {
                    if (_mark != "")
                    {
                        _output.Append(_mainarray[j]);
                        //_datah.InsertData(maxid, _mark, _mainarray[j]);
                    }
                }

                _mark = "";
                _mark += _mainarray[_markers[2]];
                _output.Append(_mark);

                for (j = _markers[2]; j < _markers[3]; j++)
                {
                    if (_mark != "")
                    {
                        _output.Append(_mainarray[j]);
                        //_datah.InsertData(maxid, _mark, _mainarray[j]);
                    }
                }

                _mark = "";
                _mark += _mainarray[_markers[3]];
                _output.Append(_mark);

                for (j = _markers[3]; j < _mainarray.Length; j++)
                {
                    if (_mark != "")
                    {
                        _output.Append(_mainarray[j]);
                        //_datah.InsertData(maxid, _mark, _mainarray[j]);
                    }
                }
            }

            var _rset = _output.ToString();

            //GC.Collect();

            return _rset;
        }

        protected void ButtonResume_Click(object sender, EventArgs e)
        {
            if (ResResumeLink.Text == "")
            {
                LabelNotify.Text = "Please enter a website link";
            }

            else
            {
                var clw = new ClWebFetch();
                var clb = new ClResumeBuilder();

                Stream stm = clw.Gethtmlpage(ResResumeLink.Text);

                LiteralPreview.Text = parseresume(stm.ToString());
            }
        }
    }
}