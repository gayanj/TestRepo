using System;
using System.Globalization;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.Adapters;

namespace JB.ControlAdapters
{
    public class MyDataListAdapter : WebControlAdapter
    {
        /// <summary>
        /// Data List Rendering happens here
        /// add / remove functionality as required
        /// </summary>
        private WebControlAdapterExtender _extender;

        private WebControlAdapterExtender Extender
        {
            get
            {
                //if (((_extender == null) && (Control != null)) ||
                //    ((_extender != null) && (Control != _extender.AdaptedControl)))
                //{
                _extender = new WebControlAdapterExtender(Control);
                //}

                //System.Diagnostics.Debug.Assert(_extender != null, "CSS Friendly adapters internal error", "Null extender instance");
                return _extender;
            }
        }

        private int RepeatColumns
        {
            get
            {
                var dataList = Control as DataList;
                var nRet = 1;
                if (dataList != null)
                {
                    if (dataList.RepeatColumns == 0)
                    {
                        if (dataList.RepeatDirection == RepeatDirection.Horizontal)
                        {
                            nRet = dataList.Items.Count;
                        }
                    }
                    else
                    {
                        nRet = dataList.RepeatColumns;
                    }
                }
                return nRet;
            }
        }

        //protected override void OnInit(EventArgs e)
        //{
        //    base.OnInit(e);

        //    //if (Extender.AdapterEnabled)
        //    //{
        //        RegisterScripts();
        //    //}
        //}

        protected override void RenderBeginTag(HtmlTextWriter writer)
        {
            //if (Extender.AdapterEnabled)
            //{
            Extender.RenderBeginTag(writer, "");
            //}
            //else
            //{
            //    base.RenderBeginTag(writer);
            //}
        }

        protected override void RenderEndTag(HtmlTextWriter writer)
        {
            //if (Extender.AdapterEnabled)
            //{
            Extender.RenderEndTag(writer);
            //}
            //else
            //{
            //    base.RenderEndTag(writer);
            //}
        }

        protected override void RenderContents(HtmlTextWriter writer)
        {
            //if (Extender.AdapterEnabled)
            //{
            var dataList = Control as DataList;
            if (dataList != null)
            {
                //writer.Indent++;
                //writer.WriteLine();
                //writer.WriteBeginTag("div");
                //writer.WriteAttribute("cellpadding", "0");
                //writer.WriteAttribute("cellspacing", "0");
                //writer.WriteAttribute("summary", Control.ToolTip);
                //writer.Write(HtmlTextWriter.TagRightChar);
                //writer.Indent++;

                #region header

                if (dataList.HeaderTemplate != null)
                {
                    var container = new PlaceHolder();
                    dataList.HeaderTemplate.InstantiateIn(container);
                    container.DataBind();

                    if ((container.Controls.Count == 1) && container.Controls[0] is LiteralControl)
                    {
                        writer.WriteLine();
                        writer.WriteBeginTag("caption");
                        writer.Write(HtmlTextWriter.TagRightChar);

                        var literalControl = container.Controls[0] as LiteralControl;
                        writer.Write(literalControl.Text.Trim());

                        writer.WriteEndTag("caption");
                    }
                    else
                    {
                        //writer.WriteLine();
                        //writer.WriteBeginTag("div");
                        //writer.Write(HtmlTextWriter.TagRightChar);
                        //writer.Indent++;

                        //writer.WriteLine();
                        //writer.WriteBeginTag("div");
                        //writer.Write(HtmlTextWriter.TagRightChar);
                        //writer.Indent++;

                        writer.WriteLine();
                        writer.WriteBeginTag("div");
                        writer.WriteAttribute("colspan", RepeatColumns.ToString(CultureInfo.InvariantCulture));
                        writer.Write(HtmlTextWriter.TagRightChar);
                        writer.Indent++;

                        writer.WriteLine();
                        container.RenderControl(writer);

                        //writer.Indent--;
                        //writer.WriteLine();
                        //writer.WriteEndTag("div");

                        //writer.Indent--;
                        //writer.WriteLine();
                        //writer.WriteEndTag("div");

                        writer.Indent--;
                        writer.WriteLine();
                        writer.WriteEndTag("div");
                    }
                }

                #endregion header

                #region footer

                if (dataList.FooterTemplate != null)
                {
                    //writer.WriteLine();
                    //writer.WriteBeginTag("div");
                    //writer.Write(HtmlTextWriter.TagRightChar);
                    //writer.Indent++;

                    //writer.WriteLine();
                    //writer.WriteBeginTag("div");
                    //writer.Write(HtmlTextWriter.TagRightChar);
                    //writer.Indent++;

                    writer.WriteLine();
                    writer.WriteBeginTag("div");
                    writer.WriteAttribute("colspan", RepeatColumns.ToString(CultureInfo.InvariantCulture));
                    writer.Write(HtmlTextWriter.TagRightChar);
                    writer.Indent++;

                    var container = new PlaceHolder();
                    dataList.FooterTemplate.InstantiateIn(container);
                    container.DataBind();
                    container.RenderControl(writer);

                    //writer.Indent--;
                    //writer.WriteLine();
                    //writer.WriteEndTag("div");

                    //writer.Indent--;
                    //writer.WriteLine();
                    //writer.WriteEndTag("div");

                    writer.Indent--;
                    writer.WriteLine();
                    writer.WriteEndTag("div");
                }

                #endregion footer

                #region itemtempl

                if (dataList.ItemTemplate != null)
                {
                    //writer.WriteLine();
                    //writer.WriteBeginTag("div");
                    //writer.Write(HtmlTextWriter.TagRightChar);
                    //writer.Indent++;

                    var nItemsInColumn = (int)Math.Ceiling((dataList.Items.Count) / ((Double)RepeatColumns));
                    for (var iItem = 0; iItem < dataList.Items.Count; iItem++)
                    {
                        var nRow = iItem / RepeatColumns;
                        var nCol = iItem % RepeatColumns;
                        var nDesiredIndex = iItem;
                        if (dataList.RepeatDirection == RepeatDirection.Vertical)
                        {
                            nDesiredIndex = (nCol * nItemsInColumn) + nRow;
                        }

                        if ((iItem % RepeatColumns) == 0)
                        {
                            writer.WriteLine();
                            writer.WriteBeginTag("div");
                            writer.Write(HtmlTextWriter.TagRightChar);
                            writer.Indent++;
                        }

                        writer.WriteLine();
                        writer.WriteBeginTag("div");
                        writer.Write(HtmlTextWriter.TagRightChar);
                        writer.Indent++;

                        foreach (Control itemCtrl in dataList.Items[iItem].Controls)
                        {
                            itemCtrl.RenderControl(writer);
                        }

                        writer.Indent--;
                        writer.WriteLine();
                        writer.WriteEndTag("div");

                        if (((iItem + 1) % RepeatColumns) == 0)
                        {
                            writer.Indent--;
                            writer.WriteLine();
                            writer.WriteEndTag("div");
                        }
                    }

                    if ((dataList.Items.Count % RepeatColumns) != 0)
                    {
                        writer.Indent--;
                        writer.WriteLine();
                        writer.WriteEndTag("div");
                    }

                    //writer.Indent--;
                    //writer.WriteLine();
                    //writer.WriteEndTag("div");
                }

                #endregion itemtempl

                //writer.Indent--;
                //writer.WriteLine();
                //writer.WriteEndTag("div");

                writer.Indent--;
                writer.WriteLine();
            }
            //}
            //else
            //{
            //    base.RenderContents(writer);
            //}
        }

        //private void RegisterScripts()
        //{
        //}
    }
}