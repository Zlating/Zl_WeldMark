using System;
using System.Windows.Forms;
using System.Collections.Generic;

using Tekla.Structures.Plugins;
using Tekla.Structures.Drawing;
using Tekla.Structures.Drawing.Tools;
using Tekla.Structures.Drawing.UI;

using tsg = Tekla.Structures.Geometry3d;

namespace Zl_WeldMark
{

    public class PluginData
    {
        [StructuresField("height")]
        public double height;
        [StructuresField("shop")]
        public int shop;
        [StructuresField("tw")]
        public string tw;
    }

    [Plugin("ZL_WeldMark")]
    [PluginUserInterface("ZL_WeldMark.MainForm")]
    public class Zl_WeldMark : DrawingPluginBase
    {
        #region Fields
        private PluginData data;


        private double height = 3;
        private int shop = 0;
        private TypeWeld tw = TypeWeld.T1;
        DrawingColors col = DrawingColors.Black;
        enum TypeWeld
        {
            T1,
            T3,
            T6,
            T7,
            U4,
            U6,
            U7,
            H1,
            H2,
            C2,
        }

        #endregion

        #region Properties
        private PluginData Data
        {
            get { return data; }
            set { data = value; }
        }
        #endregion

        #region Constructor
        public Zl_WeldMark(PluginData data)
        {
            Data = data;
        }
        #endregion

        #region Overrides
        public override List<InputDefinition> DefineInput()
        {
            //
            // This is an example for selecting two points; change this to suit your needs.
            //
            List<InputDefinition> inputs = new List<InputDefinition>();
            DrawingHandler drawingHandler = new DrawingHandler();

            if (drawingHandler.GetConnectionStatus())
            {
                Picker picker = drawingHandler.GetPicker();

                ViewBase view = null;
                PointList points = new PointList();

                StringList prompts = new StringList();
                prompts.Add("Pick first point");
                prompts.Add("Pick second point");

                picker.PickPoints(2, prompts, out points, out view);
                inputs.Add(InputDefinitionFactory.CreateInputDefinition(view, points));
            }

            return inputs;
        }

        public override bool Run(List<InputDefinition> inputs)
        {
            try
            {
                ViewBase view = InputDefinitionFactory.GetView(inputs[0]);
                PointList points = InputDefinitionFactory.GetPoints(inputs[0]);

                tsg.Point p1 = points[0] as tsg.Point;
                tsg.Point p2 = points[1] as tsg.Point;

                // default data
                #region Default data

                if (!IsDefaultValue(data.height)) height = data.height;
                if (!IsDefaultValue(data.shop)) height = data.shop;
                if (!IsDefaultValue(data.tw))
                {
                    try
                    {
                        tw = (TypeWeld)Enum.Parse(typeof(TypeWeld), data.tw);
                    }
                    catch { }
                }

                #endregion

                #region Drawing

                double dx = (shop == 1 ? 5 : 8);


                Line lineArrow = RLine(view, p1, p2, true);
                lineArrow.Insert();
                Line lineCen = RLine(view, p2, new tsg.Point((p2).X + dx, (p2).Y));
                lineCen.Insert();

                Line lineTop = RLine(view, new tsg.Point((p2).X + dx, (p2).Y), new tsg.Point((p2).X + dx + height, (p2).Y + height));
                lineTop.Insert();
                Line lineBottom = RLine(view, new tsg.Point((p2).X + dx, (p2).Y), new tsg.Point((p2).X + dx + height, (p2).Y - height));
                lineBottom.Insert();

                Text t = new Text(view, new tsg.Point((p2).X + dx + 5, (p2).Y), tw.ToString());
                t.Attributes.Alignment = TextAlignment.Left;
                t.Attributes.ArrowHead.Head = ArrowheadTypes.NoArrow;
                t.Attributes.ArrowHead.ArrowPosition = ArrowheadPositions.None;
                t.Attributes.ArrowHead.Height = 0;
                t.Attributes.ArrowHead.Width = 0;
                t.Placing = PlacingTypes.PointPlacing();
                t.Attributes.Frame.Type = FrameTypes.None;
                t.Attributes.Font.Color = col;
                t.Attributes.Font.Height = height;
                t.Insert();

                if (shop != 0)
                {
                    Line LineErection = RLine(view, p2, new tsg.Point((p2).X, (p2).Y + 5));
                    LineErection.Insert();
                    PointList pl = new PointList();
                    pl.Add(LineErection.EndPoint);
                    pl.Add(new tsg.Point(LineErection.EndPoint.X + height, LineErection.EndPoint.Y - 0.5));
                    pl.Add(new tsg.Point(LineErection.EndPoint.X, LineErection.EndPoint.Y - 1));
                    Polygon Erection = GetTriangle(view, pl, true);
                    Erection.Insert();
                }

                #region Type Weld
                Polygon triangle_top = GetTriangle(view, new tsg.Point(lineCen.StartPoint.X + (dx - 4), lineCen.StartPoint.Y));
                Polygon triangle_bottom = GetTriangle(view, new tsg.Point(lineCen.StartPoint.X + (dx - 4), lineCen.StartPoint.Y), true);

                Line doule_line_1 = RLine(view,
                    new tsg.Point(lineCen.StartPoint.X + (dx - 4), lineCen.StartPoint.Y),
                    new tsg.Point(lineCen.StartPoint.X + (dx - 4), lineCen.StartPoint.Y + height));

                Line doule_line_2 = RLine(view,
                    new tsg.Point(lineCen.StartPoint.X + (dx - 4) + 1.5, lineCen.StartPoint.Y),
                    new tsg.Point(lineCen.StartPoint.X + (dx - 4) + 1.5, lineCen.StartPoint.Y + height));

                Line dl_line_45 = RLine(view,
                    new tsg.Point(lineCen.StartPoint.X + (dx - 4), lineCen.StartPoint.Y),
                    new tsg.Point(lineCen.StartPoint.X + (dx - 4) + height, lineCen.StartPoint.Y + height));

                Arc arc = new Arc(view, new tsg.Point(lineCen.StartPoint.X + height, lineCen.StartPoint.Y), lineCen.StartPoint, height * 0.5);
                arc.Attributes.Line.Color = col;
                arc.Attributes.Arrowhead.ArrowPosition = ArrowheadPositions.None;
                arc.Attributes.Line.Type = LineTypes.SolidLine;

                if (tw == TypeWeld.T1 || tw == TypeWeld.U4 || tw == TypeWeld.H1)
                {
                    triangle_top.Insert();
                }
                else if (tw == TypeWeld.T3 || tw == TypeWeld.H2)
                {
                    triangle_top.Insert();
                    triangle_bottom.Insert();
                }
                else if (tw == TypeWeld.C2)
                {
                    doule_line_1.Insert();
                    doule_line_2.Insert();
                }
                else if (tw == TypeWeld.T6 || tw == TypeWeld.U6)
                {
                    doule_line_1.Insert();
                    dl_line_45.Insert();
                }
                else if (tw == TypeWeld.T7 || tw == TypeWeld.U7)
                {
                    doule_line_1.Insert();
                    dl_line_45.Insert();
                    arc.Insert();
                }

                #endregion
                #endregion
            }
            catch (Exception Exc)
            {
                MessageBox.Show(Exc.ToString());
            }

            return true;
        }


        Line RLine(ViewBase v, tsg.Point p1, tsg.Point p2, bool arrow = false)
        {
            Line lineArrow = new Line(v, p1, p2);
            lineArrow.Attributes.Line.Color = col;
            lineArrow.Attributes.Arrowhead.ArrowPosition = ArrowheadPositions.None;
            if (arrow)
            {
                lineArrow.Attributes.Arrowhead.ArrowPosition = ArrowheadPositions.Start;
                lineArrow.Attributes.Arrowhead.Width = 2.5;
                lineArrow.Attributes.Arrowhead.Height = 1.5;
                lineArrow.Attributes.Arrowhead.Head = ArrowheadTypes.FilledArrow;
            }
            return lineArrow;
        }

        Polygon GetTriangle(ViewBase v, tsg.Point p1, bool reverse = false, bool filled = false)
        {
            PointList pl = new PointList();
            pl.Add(p1);
            pl.Add(new tsg.Point(p1.X + 3, p1.Y));
            pl.Add(new tsg.Point(p1.X, p1.Y + (reverse == false ? 3 : -3)));
            Polygon poly = new Polygon(v, pl);
            poly.Attributes.Line.Color = col;
            if (filled)
            {
                poly.Attributes.Hatch.Name = "hardware_SOLID";
                poly.Attributes.Hatch.Color = DrawingHatchColors.Black;
            }
            return poly;
        }

        Polygon GetTriangle(ViewBase v, PointList pl, bool filled = false)
        {
            Polygon poly = GetTriangle(v, new tsg.Point(), filled);
            poly.Points.Clear();
            poly.Points = pl;
            return poly;
        }


        #endregion
    }
}