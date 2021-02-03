using System;
using System.Drawing;
using System.Windows.Forms;

namespace MastermindWinForms
{
    /// <summary>
    /// Dessine une boule colorée.
    /// </summary>
    public class Ball : Control
    {
        private DragDropTarget _dragDropTarget;

        /// <summary>
        /// Couleur de la boule.
        /// </summary>
        public Color Color { get; set; } = Color.Red;

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
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            var layer = this.CreateGraphics();
            var brush = new SolidBrush(this.Color);
            var pen = new Pen(Color.Black, 2);

            layer.DrawEllipse(pen, 0, 0, this.Width - 1, this.Height - 1);
            layer.FillEllipse(brush, 0, 0, this.Width - 1, this.Height - 1);
        }

        /// <summary>
        /// Début du glisser/déplacer de la couleur.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (this.DragDropTarget == DragDropTarget.Source)
            {
                this.DoDragDrop(this.Color, DragDropEffects.Copy);
            }
        }

        /// <summary>
        /// Survol d'une boule lors d'un grisser/déplacer.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnDragEnter(DragEventArgs e)
        {
            if (this.DragDropTarget != DragDropTarget.Disabled)
            {
                if (e.Data.GetDataPresent(typeof(Color)) == true)
                {
                    e.Effect = DragDropEffects.Copy;
                }
            }
        }

        /// <summary>
        /// Déposer une couleur dans le processus de grisser/déplacer.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnDragDrop(DragEventArgs e)
        {
            if (this.DragDropTarget == DragDropTarget.Target)
            {
                this.Color = (Color)e.Data.GetData(typeof(Color));
                this.Refresh();
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
