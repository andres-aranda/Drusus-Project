using System;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Drusus
{
    public static class ThemeHelper
    {
        // Paleta de Colores Modernos (Premium Dark Harmony)
        public static readonly Color ColorBgMain = Color.FromArgb(24, 23, 53);        // Fondo principal profundo
        public static readonly Color ColorBgCard = Color.FromArgb(34, 33, 74);        // Fondo de tarjetas/paneles
        public static readonly Color ColorAccent = Color.FromArgb(95, 77, 221);       // Violeta brillante de acento
        public static readonly Color ColorAccentHover = Color.FromArgb(120, 105, 240); // Hover violeta
        public static readonly Color ColorSuccess = Color.FromArgb(46, 204, 113);     // Verde esmeralda para haberes
        public static readonly Color ColorDanger = Color.FromArgb(231, 76, 60);       // Rojo coral para deudas/gastos
        public static readonly Color ColorTextLight = Color.FromArgb(245, 246, 250);   // Texto principal brillante
        public static readonly Color ColorTextMuted = Color.FromArgb(170, 175, 205);   // Texto secundario / gris
        public static readonly Color ColorGridLine = Color.FromArgb(45, 43, 85);       // Línea de grilla sutil

        // Fuente estándar moderna
        private static readonly Font FontTitle = new Font("Segoe UI", 16F, FontStyle.Bold);
        private static readonly Font FontSubtitle = new Font("Segoe UI", 12F, FontStyle.Bold);
        private static readonly Font FontBody = new Font("Segoe UI", 10F, FontStyle.Regular);
        private static readonly Font FontSmall = new Font("Segoe UI", 8.5F, FontStyle.Regular);

        /// <summary>
        /// Aplica de forma recursiva estilos visuales premium a un formulario y a todos sus controles hijos.
        /// </summary>
        public static void StyleForm(Form form)
        {
            if (form == null) return;

            form.BackColor = ColorBgMain;
            form.ForeColor = ColorTextLight;
            form.Font = FontBody;

            // Recorrer y aplicar estilos a todos los controles hijos recursivamente
            StyleControls(form.Controls);
        }

        private static void StyleControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                // Aplicar estilo según el tipo de control
                if (ctrl is Panel panel)
                {
                    // Si el panel representa una tarjeta/card, darle el fondo secundario
                    if (panel.Name.ToLower().Contains("card") || panel.Name.ToLower().Contains("menu") || panel.Name.ToLower().Contains("barra"))
                    {
                        panel.BackColor = ColorBgCard;
                    }
                    else
                    {
                        panel.BackColor = Color.Transparent;
                    }
                    StyleControls(panel.Controls);
                }
                else if (ctrl is GroupBox groupBox)
                {
                    groupBox.ForeColor = ColorTextLight;
                    groupBox.BackColor = ColorBgCard;
                    groupBox.Font = FontSubtitle;
                    StyleControls(groupBox.Controls);
                }
                else if (ctrl is DataGridView dgv)
                {
                    StyleDataGridView(dgv);
                }
                else if (ctrl is IconButton iconBtn)
                {
                    StyleIconButton(iconBtn);
                }
                else if (ctrl is Button btn)
                {
                    StyleRegularButton(btn);
                }
                else if (ctrl is TextBox txt)
                {
                    StyleTextBox(txt);
                }
                else if (ctrl is ComboBox cmb)
                {
                    StyleComboBox(cmb);
                }
                else if (ctrl is Label lbl)
                {
                    StyleLabel(lbl);
                }
                else if (ctrl is RadioButton rb)
                {
                    rb.Font = FontBody;
                    rb.ForeColor = ColorTextLight;
                }
                else if (ctrl is CheckBox cb)
                {
                    cb.Font = FontBody;
                    cb.ForeColor = ColorTextLight;
                }
                else if (ctrl is NumericUpDown nud)
                {
                    nud.BackColor = ColorBgCard;
                    nud.ForeColor = ColorTextLight;
                    nud.Font = FontBody;
                    nud.BorderStyle = BorderStyle.FixedSingle;
                }
                else if (ctrl is DateTimePicker dtp)
                {
                    dtp.Font = FontBody;
                    dtp.CalendarMonthBackground = ColorBgCard;
                    dtp.CalendarTitleBackColor = ColorAccent;
                    dtp.CalendarTitleForeColor = ColorTextLight;
                }

                // Si tiene controles hijos pero no es un Panel o GroupBox ya procesado
                if (ctrl.Controls.Count > 0 && !(ctrl is Panel) && !(ctrl is GroupBox))
                {
                    StyleControls(ctrl.Controls);
                }
            }
        }

        private static void StyleDataGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = ColorBgMain;
            dgv.GridColor = ColorGridLine;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.RowHeadersVisible = false; // Ocultar barra lateral izquierda para un diseño más moderno

            // Altura de fila cómoda y fluida
            dgv.RowTemplate.Height = 36;
            dgv.ColumnHeadersHeight = 40;

            // Estilo de los Encabezados
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle
            {
                BackColor = ColorBgCard,
                ForeColor = ColorTextLight,
                Font = new Font("Segoe UI", 10.5F, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                SelectionBackColor = ColorBgCard,
                SelectionForeColor = ColorTextLight
            };
            dgv.ColumnHeadersDefaultCellStyle = headerStyle;

            // Estilo por Defecto de Celdas
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle
            {
                BackColor = ColorBgMain,
                ForeColor = ColorTextLight,
                Font = FontBody,
                SelectionBackColor = ColorAccent,
                SelectionForeColor = ColorTextLight
            };
            dgv.DefaultCellStyle = cellStyle;

            // Alternancia de filas para facilitar lectura
            DataGridViewCellStyle altStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(29, 28, 62), // Tono ligeramente más claro que BgMain
                ForeColor = ColorTextLight,
                Font = FontBody,
                SelectionBackColor = ColorAccent,
                SelectionForeColor = ColorTextLight
            };
            dgv.AlternatingRowsDefaultCellStyle = altStyle;
        }

        private static void StyleIconButton(IconButton btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = FontBody;

            // Si es un botón secundario del menú lateral
            if (btn.Parent != null && btn.Parent.Name.ToLower().Contains("menu"))
            {
                btn.BackColor = Color.Transparent;
                btn.ForeColor = ColorTextMuted;
                btn.IconColor = ColorTextMuted;
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(31, 30, 68);
            }
            else
            {
                // Botón general destacado
                btn.BackColor = ColorAccent;
                btn.ForeColor = ColorTextLight;
                btn.IconColor = ColorTextLight;
                btn.FlatAppearance.MouseOverBackColor = ColorAccentHover;
            }
        }

        private static void StyleRegularButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;

            // Diferenciar botones de acción críticos vs normales
            string txt = btn.Text.ToLower();
            if (txt.Contains("guardar") || txt.Contains("cobrar") || txt.Contains("crear") || txt.Contains("aceptar") || txt.Contains("finalizar"))
            {
                btn.BackColor = ColorAccent;
                btn.ForeColor = ColorTextLight;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.MouseOverBackColor = ColorAccentHover;
            }
            else if (txt.Contains("eliminar") || txt.Contains("limpiar") || txt.Contains("cancelar"))
            {
                btn.BackColor = Color.Transparent;
                btn.ForeColor = ColorDanger;
                btn.FlatAppearance.BorderSize = 1;
                btn.FlatAppearance.BorderColor = ColorDanger;
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 24, 45);
            }
            else
            {
                // Botones generales / secundarios
                btn.BackColor = ColorBgCard;
                btn.ForeColor = ColorTextLight;
                btn.FlatAppearance.BorderSize = 1;
                btn.FlatAppearance.BorderColor = ColorAccent;
                btn.FlatAppearance.MouseOverBackColor = ColorAccent;
            }
        }

        private static void StyleTextBox(TextBox txt)
        {
            txt.BackColor = ColorBgCard;
            txt.ForeColor = ColorTextLight;
            txt.Font = FontBody;
            txt.BorderStyle = BorderStyle.FixedSingle;
        }

        private static void StyleComboBox(ComboBox cmb)
        {
            cmb.BackColor = ColorBgCard;
            cmb.ForeColor = ColorTextLight;
            cmb.Font = FontBody;
            cmb.FlatStyle = FlatStyle.Flat;
        }

        private static void StyleLabel(Label lbl)
        {
            lbl.ForeColor = ColorTextLight;

            // Identificar jerarquía visual según nombres o tamaño original
            if (lbl.Name.ToLower().Contains("titulo") || lbl.Font.Size >= 20F)
            {
                lbl.Font = FontTitle;
                lbl.ForeColor = ColorTextLight;
            }
            else if (lbl.Name.ToLower().Contains("sub") || (lbl.Font.Size >= 12F && lbl.Font.Size < 20F))
            {
                lbl.Font = FontSubtitle;
                lbl.ForeColor = ColorAccent;
            }
            else if (lbl.Name.ToLower().Contains("muted") || lbl.Name.ToLower().Contains("label"))
            {
                lbl.Font = FontSmall;
                lbl.ForeColor = ColorTextMuted;
            }
            else
            {
                lbl.Font = FontBody;
            }

            // Colores especiales de deudas
            if (lbl.Name.ToLower().Contains("deuda"))
            {
                lbl.Font = FontSubtitle;
                // Si la deuda tiene valor se actualizará dinámicamente en su código, pero definimos base.
            }
        }
    }
}
