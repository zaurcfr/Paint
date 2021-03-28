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
            if (FigureFactory.GetFigure() is Rectangle rectangle)
            {
                rectangle.Point = e.Location;
                rectangle.Size = new Size(int.Parse(WidthTxtb.Text), int.Parse(HeightTxtb.Text));
                rectangle.Color = FigureColor;
                rectangle.isFilled = true;
                Figures.Add(rectangle);
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
                        else a.DrawRectangle(pen, rectangle.Point.X, rectangle.Point.Y, rectangle.Size.Width, rectangle.Size.Height);
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
