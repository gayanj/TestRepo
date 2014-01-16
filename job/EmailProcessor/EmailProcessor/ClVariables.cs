using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmailProcessor
{
    class ClVariables
    {
        private string p_emailfrom;
        private int p_HtmlIterations;
        private string p_constring;
        private string p_emuser;
        private string p_empwd;
        private int p_emport;
        private string p_emserver;
        
        public string emailfrom
        {
            get { return p_emailfrom; }
            set { p_emailfrom = value; }
        }
        public int HtmlIterations
        {
            get { return p_HtmlIterations; }
            set { p_HtmlIterations = value; }
        }
        public string constring
        {
            get { return p_constring; }
            set { p_constring = value; }
        }
        public string emuser
        {
            get { return p_emuser; }
            set { p_emuser = value; }
        }
        public string empwd
        {
            get { return p_empwd; }
            set { p_empwd = value; }
        }
        public int emport
        {
            get { return p_emport; }
            set { p_emport = value; }
        }
        public string emserver
        {
            get { return p_emserver; }
            set { p_emserver = value; }
        }
    }
}
