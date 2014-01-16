﻿using System;
using System.Collections;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.Adapters;

namespace JB.ControlAdapters
{
    public class MyGridViewAdapter : WebControlAdapter
    {
        /// <summary>
        /// This handles GridView Rendering
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

                //System.Diagnostics.Debug.Assert(_extender != null, "Adapters internal error", "Null extender instance");
                return _extender;
            }
        }

        //protected override void OnInit(EventArgs e)
        //{
        //    base.OnInit(e);

        //    //if (Extender.AdapterEnabled)
        //    //{
        //    //    //RegisterScripts();
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
            var gridView = Control as GridView;
            if (gridView != null)
            {
                //writer.Indent++;
                //WritePagerSection(writer, PagerPosition.Top);

                //writer.WriteLine();
                //writer.WriteBeginTag("div");
                //writer.WriteAttribute("cellpadding", "0");
                //writer.WriteAttribute("cellspacing", "0");
                //writer.WriteAttribute("summary", Control.ToolTip);

                //if (!String.IsNullOrEmpty(gridView.CssClass))
                //{
                //    //writer.WriteAttribute("class", gridView.CssClass);
                //}

                //writer.Write(HtmlTextWriter.TagRightChar);
                //writer.Indent++;

                var rows = new ArrayList();
                GridViewRowCollection gvrc = null;

                ///////////////////// HEAD /////////////////////////////

                rows.Clear();
                if (gridView.ShowHeader && (gridView.HeaderRow != null))
                {
                    rows.Add(gridView.HeaderRow);
                }

                gvrc = new GridViewRowCollection(rows);
                WriteRows(writer, gridView, gvrc, "div");

                ///////////////////// BODY /////////////////////////////
                rows.Clear();
                WriteRows(writer, gridView, gridView.Rows, "div");

                ///////////////////// FOOT /////////////////////////////

                rows.Clear();
                if (gridView.ShowFooter && (gridView.FooterRow != null))
                {
                    rows.Add(gridView.FooterRow);
                }
                gvrc = new GridViewRowCollection(rows);
                WriteRows(writer, gridView, gvrc, "div");

                ////////////////////////////////////////////////////////

                //writer.Indent--;
                //writer.WriteLine();
                //writer.WriteEndTag("div");
                WritePagerSection(writer, PagerPosition.Bottom);

                writer.Indent--;
                writer.WriteLine();
            }
            //}
            //else
            //{
            //    base.RenderContents(writer);
            //}
        }

        private void WriteRows(HtmlTextWriter writer, GridView gridView, GridViewRowCollection rows, string tableSection)
        {
            if (rows.Count > 0)
            {
                writer.WriteLine();
                writer.WriteBeginTag(tableSection);
                writer.Write(HtmlTextWriter.TagRightChar);
                writer.Indent++;

                foreach (GridViewRow row in rows)
                {
                    writer.WriteLine();
                    writer.WriteBeginTag("div");

                    var className = GetRowClass(gridView, row);
                    if (!String.IsNullOrEmpty(className))
                    {
                        writer.WriteAttribute("class", className);
                    }

                    //  Uncomment the following block of code if you want to add arbitrary attributes.

                    foreach (string key in row.Attributes.Keys)
                    {
                        writer.WriteAttribute(key, row.Attributes[key]);
                    }

                    writer.Write(HtmlTextWriter.TagRightChar);
                    writer.Indent++;

                    for (var index = 0; index < row.Cells.Count; index++)
                    {
                        var cell = row.Cells[index];
                        var fieldCell = cell as DataControlFieldCell;
                        if ((fieldCell != null) && (fieldCell.ContainingField != null))
                        {
                            var field = fieldCell.ContainingField;
                            if (!field.Visible)
                            {
                                cell.Visible = false;
                            }

                            if ((field.ItemStyle != null) && (!String.IsNullOrEmpty(field.ItemStyle.CssClass)))
                            {
                                if (!String.IsNullOrEmpty(cell.CssClass))
                                {
                                    cell.CssClass += " ";
                                }
                                cell.CssClass += field.ItemStyle.CssClass;
                            }
                        }

                        writer.WriteLine();
                        cell.RenderControl(writer);
                    }

                    writer.Indent--;
                    writer.WriteLine();
                    writer.WriteEndTag("div");
                }

                writer.Indent--;
                writer.WriteLine();
                writer.WriteEndTag(tableSection);
            }
        }

        private string GetRowClass(GridView gridView, GridViewRow row)
        {
            var className = "";

            if ((row.RowState & DataControlRowState.Alternate) == DataControlRowState.Alternate)
            {
                className += " AspNet-GridView-Alternate ";
                if (gridView.AlternatingRowStyle != null)
                {
                    className += gridView.AlternatingRowStyle.CssClass;
                }
            }
            if (row.Equals(gridView.HeaderRow) && (gridView.HeaderStyle != null) &&
                (!String.IsNullOrEmpty(gridView.HeaderStyle.CssClass)))
            {
                className += " " + gridView.HeaderStyle.CssClass;
            }

            else if (row.Equals(gridView.FooterRow) && (gridView.FooterStyle != null) &&
                     (!String.IsNullOrEmpty(gridView.FooterStyle.CssClass)))
            {
                className = "PagerStyle";
            }

            else if ((gridView.RowStyle != null) && (!String.IsNullOrEmpty(gridView.RowStyle.CssClass)))
            {
                className += " " + gridView.RowStyle.CssClass;
            }

            if ((row.RowState & DataControlRowState.Edit) == DataControlRowState.Edit)
            {
                className += " AspNet-GridView-Edit ";
                if (gridView.EditRowStyle != null)
                {
                    className += gridView.EditRowStyle.CssClass;
                }
            }

            if ((row.RowState & DataControlRowState.Insert) == DataControlRowState.Insert)
            {
                className += " AspNet-GridView-Insert ";
            }

            if ((row.RowState & DataControlRowState.Selected) == DataControlRowState.Selected)
            {
                className += " AspNet-GridView-Selected ";
                if (gridView.SelectedRowStyle != null)
                {
                    className += gridView.SelectedRowStyle.CssClass;
                }
            }

            return className;
        }

        private void WritePagerSection(HtmlTextWriter writer, PagerPosition pos)
        {
            const string className = "PagerStyle";
            var gridView = Control as GridView;
            if ((gridView.Rows.Count > 0) && gridView.AllowPaging && ((gridView.PagerSettings.Position == pos)))
            {
                Table innerTable = null;
                //if ((pos == PagerPosition.Top) &&
                //    (gridView.TopPagerRow != null) &&
                //    (gridView.TopPagerRow.Cells.Count == 1) &&
                //    (gridView.TopPagerRow.Cells[0].Controls.Count == 1) &&
                //    typeof(Table).IsAssignableFrom(gridView.TopPagerRow.Cells[0].Controls[0].GetType()))
                //{
                //    innerTable = gridView.TopPagerRow.Cells[0].Controls[0] as Table;
                //}
                if ((pos == PagerPosition.Bottom) && (gridView.BottomPagerRow != null) &&
                    (gridView.BottomPagerRow.Cells.Count == 1) && (gridView.BottomPagerRow.Cells[0].Controls.Count == 1) &&
                    gridView.BottomPagerRow.Cells[0].Controls[0] is Table)
                {
                    innerTable = gridView.BottomPagerRow.Cells[0].Controls[0] as Table;
                }

                if ((innerTable != null) && (innerTable.Rows.Count == 1))
                {
                    //className += (pos == PagerPosition.Top) ? "Top " : "Bottom ";
                    //if (gridView.PagerStyle != null)
                    //{
                    //    className += gridView.PagerStyle.CssClass;
                    //}
                    //className = className.Trim();

                    writer.WriteLine();
                    writer.WriteBeginTag("div");
                    writer.WriteAttribute("class", className);
                    writer.Write(HtmlTextWriter.TagRightChar);
                    writer.Indent++;

                    var row = innerTable.Rows[0];

                    for (var index = 0; index < row.Cells.Count; index++)
                    {
                        var cell = row.Cells[index];
                        if (row.Cells.Count > 1)
                        {
                            foreach (Control ctrl in cell.Controls)
                            {
                                writer.WriteLine();
                                ctrl.RenderControl(writer);
                            }
                        }
                    }

                    writer.Indent--;
                    writer.WriteLine();
                    writer.WriteEndTag("div");
                }
            }
        }
    }
}