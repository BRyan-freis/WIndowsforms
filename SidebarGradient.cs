using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class GradientPanel : Panel
{
    // Propriedades para customizar as cores do gradiente
    public Color ColorTop { get; set; } = Color.FromArgb(0, 122, 204); // Cor inicial (azul)
    public Color ColorBottom { get; set; } = Color.FromArgb(25, 35, 45); // Cor final (um cinza escuro)
    public float Angle { get; set; } = 90f; // Ângulo do gradiente

    // Construtor
    public GradientPanel()
    {
        // Ativa o double buffering para evitar cintilação (flickering)
        this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                      ControlStyles.UserPaint |
                      ControlStyles.OptimizedDoubleBuffer, true);
        this.UpdateStyles();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        // Cria o pincel de gradiente linear
        LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.ColorTop, this.ColorBottom, this.Angle);

        // Obtém o objeto Graphics
        Graphics g = e.Graphics;

        // Preenche o retângulo do painel com o gradiente
        g.FillRectangle(brush, this.ClientRectangle);

        // Chama o método OnPaint da classe base
        base.OnPaint(e);
    }
}