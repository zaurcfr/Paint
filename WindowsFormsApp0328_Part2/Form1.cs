using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp0328_Part2
{
    public partial class Form1 : Form
    {
        IFactory FigureFactory { get; set; }

        public Form1()
        {
            InitializeComponent();


            List<string> figures = new List<string> { "Rectangle", "Circle", "Triangle" };
            FigureCmbbx.Items.AddRange(figures.ToArray());
            FigureCmbbx.SelectedIndex = 0;


        }

        private void FigureCmbbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = FigureCmbbx.SelectedItem.ToString();

            if (item == "Rectangle")
            {
                FigureFactory = new RectangleFactory();
            }
            else if (item == "Circle")
            {
                FigureFactory = new CircleFactory();
            }
            else if (item == "Triangle")
            {
                FigureFactory = new TriangleFactory();
            }

        }

        List<IFigure> Figures = new List<IFigure>();

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (AutomaticRdbtn.Checked)
            {
                if (FigureFactory.GetFigure() is Rectangle rectangle)
                {
                    rectangle.Point = e.Location;
                    rectangle.Size = new Size(int.Parse(WidthTxtb.Text), int.Parse(HeightTxtb.Text));
                    rectangle.Color = FigureColor;
                    if (FillRdbtn.Checked) rectangle.isFilled = true;
                    else if (EmptyRdbtn.Checked) rectangle.isFilled = false;
                    Figures.Add(rectangle);
                }
                else if (FigureFactory.GetFigure() is Circle circle)
                {
                    circle.Point = e.Location;
                    circle.Size = new Size(int.Parse(WidthTxtb.Text), int.Parse(HeightTxtb.Text));
                    circle.Color = FigureColor;
                    if (FillRdbtn.Checked) circle.isFilled = true;
                    else if (EmptyRdbtn.Checked) circle.isFilled = false;
                    Figures.Add(circle);
                }
                else if (FigureFactory.GetFigure() is Triangle triangle)
                {
                    triangle.Point = e.Location;
                    triangle.Size = new Size(int.Parse(WidthTxtb.Text), int.Parse(HeightTxtb.Text));
                    triangle.Color = FigureColor;
                    if (FillRdbtn.Checked) triangle.isFilled = true;
                    else if (EmptyRdbtn.Checked) triangle.isFilled = false;
                    Figures.Add(triangle);
                }
            }
            else if (ManualRdbtn.Checked)
            {
                if (FigureFactory.GetFigure() is Rectangle rectangle)
                {
                    rectangle.Point = startLocation;
                    rectangle.Size = new Size(endLocation.X - startLocation.X, endLocation.Y - startLocation.Y);
                    rectangle.Color = FigureColor;
                    if (FillRdbtn.Checked) rectangle.isFilled = true;
                    else if (EmptyRdbtn.Checked) rectangle.isFilled = false;
                    Figures.Add(rectangle);
                }
                else if (FigureFactory.GetFigure() is Circle circle)
                {
                    circle.Point = startLocation;
                    circle.Size = new Size(endLocation.X - startLocation.X, endLocation.Y - startLocation.Y);
                    circle.Color = FigureColor;
                    if (FillRdbtn.Checked) circle.isFilled = true;
                    else if (EmptyRdbtn.Checked) circle.isFilled = false;
                    Figures.Add(circle);
                }
                else if (FigureFactory.GetFigure() is Triangle triangle)
                {
                    triangle.Point = startLocation;
                    triangle.Size = new Size(endLocation.X - startLocation.X, endLocation.Y - startLocation.Y);
                    triangle.Color = FigureColor;
                    if (FillRdbtn.Checked) triangle.isFilled = true;
                    else if (EmptyRdbtn.Checked) triangle.isFilled = false;
                    Figures.Add(triangle);
                }
            }
            this.Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(FigureColor, 3);
            SolidBrush solidBrush = new SolidBrush(FigureColor);
            using (var a = e.Graphics)
            {
                foreach (var item in Figures)
                {
                    if (item is Rectangle rectangle)
                    {
                        if (rectangle.isFilled) a.FillRectangle(solidBrush, rectangle.Point.X, rectangle.Point.Y, rectangle.Size.Width, rectangle.Size.Height);
                        else if (!rectangle.isFilled) a.DrawRectangle(pen, rectangle.Point.X, rectangle.Point.Y, rectangle.Size.Width, rectangle.Size.Height);
                    }
                    else if (item is Circle circle)
                    {
                        if (circle.isFilled) a.FillEllipse(solidBrush, circle.Point.X, circle.Point.Y, circle.Size.Width, circle.Size.Height);
                        else if (!circle.isFilled) a.DrawEllipse(pen, circle.Point.X, circle.Point.Y, circle.Size.Width, circle.Size.Height);
                    }
                    else if (item is Triangle triangle)
                    {
                        Point[] points = new Point[3]
                        {
                            new Point(triangle.Point.X,triangle.Point.Y),
                            new Point(triangle.Point.X+triangle.Size.Width/2,triangle.Point.Y+triangle.Size.Height),
                            new Point(triangle.Point.X-triangle.Size.Width/2,triangle.Point.Y+triangle.Size.Height)
                        };
                        if (triangle.isFilled) a.FillPolygon(solidBrush, points);
                        else if (!triangle.isFilled) a.DrawPolygon(pen, points);
                    }
                }
            }
        }

        Color FigureColor { get; set; }
        private void selectBtn_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            var result = colorDialog.ShowDialog();
            if (result == DialogResult.OK) FigureColor = colorDialog.Color;
        }



        Point startLocation, endLocation;

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            endLocation = e.Location;
        }


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            startLocation = e.Location;
        }
    }

    interface IFigure
    {
        Point Point { get; set; }
        Size Size { get; set; }
        Color Color { get; set; }
        bool isFilled { get; set; }

    }
    class Rectangle : IFigure
    {
        public Point Point { get; set; }
        public Size Size { get; set; }
        public Color Color { get; set; }
        public bool isFilled { get; set; }
    }
    class Circle : IFigure
    {
        public Point Point { get; set; }
        public Size Size { get; set; }
        public Color Color { get; set; }
        public bool isFilled { get; set; }
    }
    class Triangle : IFigure
    {
        public Point Point { get; set; }
        public Size Size { get; set; }
        public Color Color { get; set; }
        public bool isFilled { get; set; }
    }

    interface IFactory
    {
        IFigure GetFigure();
    }
    class RectangleFactory : IFactory
    {
        public IFigure GetFigure()
        {
            return new Rectangle();
        }
    }
    class CircleFactory : IFactory
    {
        public IFigure GetFigure()
        {
            return new Circle();
        }
    }
    class TriangleFactory : IFactory
    {
        public IFigure GetFigure()
        {
            return new Triangle();
        }
    }


}
