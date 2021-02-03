using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace MastermindWpf
{
    /// <summary>
    /// Dessine une boule colorée.
    /// </summary>
    public class Ball : Control
    {
        private static Action EmptyDelegate = delegate () { };
        private DragDropTarget _dragDropTarget;

        /// <summary>
        /// Couleur de la boule.
        /// </summary>
        public Color Color { get; set; } = Colors.Red;

        /// <summary>
        /// Authorise le DragDrop (au départ ou à l'arrivée).
        /// </summary>
        public DragDropTarget DragDropTarget
        {
            get { return _dragDropTarget; }
            set
            {
                _dragDropTarget = value;
                this.AllowDrop = (_dragDropTarget != DragDropTarget.Disabled);
            }
        }

        /// <summary>
        /// Dessine une boule en utilisant la <see cref="Color"/>.
        /// </summary>
        /// <param name="dc"></param>
        protected override void OnRender(DrawingContext dc)
        {
            var brush = new SolidColorBrush(this.Color);
            var pen = new Pen(new SolidColorBrush(Colors.Black), 2.0);
            var center = new Point(this.Width / 2, this.Height / 2);

            dc.DrawEllipse(brush, pen, center, this.Width / 2, this.Height / 2);
        }

        /// <summary>
        /// Début du glisser/déplacer de la couleur.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            if (this.DragDropTarget == DragDropTarget.Source &&
                e.LeftButton == MouseButtonState.Pressed)
            {
                DragDrop.DoDragDrop(this, this.Color, DragDropEffects.Copy);
            }
        }

        /// <summary>
        /// Survol d'une boule lors d'un grisser/déplacer.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnDragOver(DragEventArgs e)
        {
            if (this.DragDropTarget != DragDropTarget.Disabled)
            {
                if (e.Data.GetDataPresent(typeof(Color)) == true)
                {
                    e.Effects = DragDropEffects.Copy;
                }
            }
        }

        /// <summary>
        /// Déposer une couleur dans le processus de grisser/déplacer.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnDrop(DragEventArgs e)
        {
            if (this.DragDropTarget == DragDropTarget.Target)
            {
                this.Color = (Color)e.Data.GetData(typeof(Color));
                this.InvalidateVisual();
            }
        }
    }

    /// <summary />
    public enum DragDropTarget
    {
        /// <summary />
        Disabled,
        /// <summary />
        Source,
        /// <summary />
        Target
    }
}
