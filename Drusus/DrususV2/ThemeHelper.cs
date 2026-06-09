using System;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace DrususV2
{
    public static class ThemeHelper
    {
        // Paleta de Colores Ultra-Moderna (High-End Dark Cyberpunk Harmony)
        public static readonly Color ColorBgMain = Color.FromArgb(19, 18, 48);          // Fondo principal ultra profundo
        public static readonly Color ColorBgCard = Color.FromArgb(27, 25, 62);          // Fondo de tarjetas y paneles
        public static readonly Color ColorAccent = Color.FromArgb(108, 92, 231);        // Violeta brillante cyberpunk
        public static readonly Color ColorAccentHover = Color.FromArgb(136, 122, 245);   // Hover violeta
        public static readonly Color ColorSuccess = Color.FromArgb(16, 172, 132);       // Verde esmeralda premium
        public static readonly Color ColorDanger = Color.FromArgb(255, 107, 107);       // Rojo coral moderno
        public static readonly Color ColorTextLight = Color.FromArgb(245, 246, 250);     // Texto principal brillante
        public static readonly Color ColorTextMuted = Color.FromArgb(140, 140, 168);     // Texto secundario / gris suave
        public static readonly Color ColorGridLine = Color.FromArgb(40, 37, 85);         // Línea de grilla elegante sutil
        public static readonly Color ColorBorder = Color.FromArgb(50, 46, 102);           // Bordes de controles

        // Fuentes premium modernas (Segoe UI / Roboto-like)
        private static readonly Font FontTitle = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
        private static readonly Font FontSubtitle = new Font("Segoe UI Semibold", 11.5F, FontStyle.Bold);
        private static readonly Font FontBody = new Font("Segoe UI", 9.5F, FontStyle.Regular);
        private static readonly Font FontSmall = new Font("Segoe UI", 8F, FontStyle.Regular);

        /// <summary>
        /// Aplica de forma recursiva estilos visuales premium a un formulario y a todos sus controles hijos.
        /// </summary>
        public static void StyleForm(Form form)
        {
            if (form == null) return;

            form.BackColor = ColorBgMain;
            form.ForeColor = ColorTextLight;
            form.Font = FontBody;

            // Habilitar scrollbars verticales en todos los formularios secundarios
            if (form.Name != "FormMain")
            {
                form.AutoScroll = true;
            }

            // Asignar el icono de la aplicación (grifo dorado)
            string iconPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "icono.ico");
            if (System.IO.File.Exists(iconPath))
            {
                try
                {
                    form.Icon = new System.Drawing.Icon(iconPath);
                }
                catch { /* Ignore format mismatch or lock errors */ }
            }

            // Recorrer y aplicar estilos a todos los controles hijos recursivamente
            StyleControls(form.Controls);
        }

        private static void StyleControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                if (ctrl is Panel panel)
                {
                    // Si el panel representa una tarjeta/card, darle el fondo secundario
                    string name = panel.Name.ToLower();
                    if (name.Contains("card") || name.Contains("menu") || name.Contains("barra") || name.Contains("container") || name.Contains("header"))
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
                    groupBox.ForeColor = ColorAccent;
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
                    rb.BackColor = Color.Transparent;
                }
                else if (ctrl is CheckBox cb)
                {
                    cb.Font = FontBody;
                    cb.ForeColor = ColorTextLight;
                    cb.BackColor = Color.Transparent;
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
            dgv.RowHeadersVisible = false; // Diseño limpio sin header de fila lateral
            dgv.RowTemplate.Height = 38;
            dgv.ColumnHeadersHeight = 42;
            dgv.ScrollBars = ScrollBars.Both; // Habilita barra de scroll horizontal y vertical

            // Forzar un ancho mínimo a cualquier columna añadida dinámicamente
            dgv.ColumnAdded += (s, e) =>
            {
                if (e.Column != null && e.Column.MinimumWidth < 100 && e.Column.Name != "subastaId")
                {
                    e.Column.MinimumWidth = 100;
                }
            };

            // Aplicar ancho mínimo a las columnas existentes
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (col.MinimumWidth < 100 && col.Name != "subastaId")
                {
                    col.MinimumWidth = 100;
                }
            }

            // Estilo de los Encabezados
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle
            {
                BackColor = ColorBgCard,
                ForeColor = ColorTextLight,
                Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                SelectionBackColor = ColorBgCard,
                SelectionForeColor = ColorTextLight,
                Padding = new Padding(8, 0, 8, 0)
            };
            dgv.ColumnHeadersDefaultCellStyle = headerStyle;

            // Estilo por Defecto de Celdas
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle
            {
                BackColor = ColorBgMain,
                ForeColor = ColorTextLight,
                Font = FontBody,
                SelectionBackColor = ColorAccent,
                SelectionForeColor = ColorTextLight,
                Padding = new Padding(8, 0, 8, 0)
            };
            dgv.DefaultCellStyle = cellStyle;

            // Alternancia de filas
            DataGridViewCellStyle altStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(23, 22, 57), // Ligeramente diferente para mejor contraste
                ForeColor = ColorTextLight,
                Font = FontBody,
                SelectionBackColor = ColorAccent,
                SelectionForeColor = ColorTextLight,
                Padding = new Padding(8, 0, 8, 0)
            };
            dgv.AlternatingRowsDefaultCellStyle = altStyle;
        }

        private static void StyleIconButton(IconButton btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = FontBody;
            btn.Cursor = Cursors.Hand;

            // Si es parte de un panel de menú
            if (btn.Parent != null && btn.Parent.Name.ToLower().Contains("menu"))
            {
                btn.BackColor = Color.Transparent;
                btn.ForeColor = ColorTextMuted;
                btn.IconColor = ColorTextMuted;
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 28, 77);
            }
            else
            {
                // Botón genérico moderno destacado
                btn.BackColor = ColorAccent;
                btn.ForeColor = ColorTextLight;
                btn.IconColor = ColorTextLight;
                btn.FlatAppearance.MouseOverBackColor = ColorAccentHover;
            }
        }

        private static void StyleRegularButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;

            string txt = btn.Text.ToLower();
            if (txt.Contains("guardar") || txt.Contains("cobrar") || txt.Contains("crear") || txt.Contains("aceptar") || txt.Contains("finalizar"))
            {
                btn.BackColor = ColorSuccess;
                btn.ForeColor = ColorTextLight;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 200, 150);
            }
            else if (txt.Contains("eliminar") || txt.Contains("limpiar") || txt.Contains("cancelar") || txt.Contains("deudor"))
            {
                btn.BackColor = Color.Transparent;
                btn.ForeColor = ColorDanger;
                btn.FlatAppearance.BorderSize = 1;
                btn.FlatAppearance.BorderColor = ColorDanger;
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 25, 35);
            }
            else
            {
                // Botones secundarios
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

            if (lbl.Name.ToLower().Contains("titulo") || lbl.Font.Size >= 18F)
            {
                lbl.Font = FontTitle;
                lbl.ForeColor = ColorTextLight;
            }
            else if (lbl.Name.ToLower().Contains("sub") || (lbl.Font.Size >= 12F && lbl.Font.Size < 18F))
            {
                lbl.Font = FontSubtitle;
                lbl.ForeColor = ColorAccent;
            }
            else if (lbl.Name.ToLower().Contains("muted") || lbl.Name.ToLower().Contains("info") || lbl.Font.Size < 9F)
            {
                lbl.Font = FontSmall;
                lbl.ForeColor = ColorTextMuted;
            }
            else
            {
                lbl.Font = FontBody;
            }

            // Deudas se marcan en rojo si son positivas
            if (lbl.Name.ToLower().Contains("deuda"))
            {
                lbl.Font = FontSubtitle;
            }
        }
    }
}
