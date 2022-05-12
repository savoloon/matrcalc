using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        static private int DefColumnWidth = 45;
        static private int DefRowHeight = 20;
        public Matrix Buf = new Matrix(1, 1);

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;

            convertToDefaultView(MatrixA);
            convertToDefaultView(MatrixB);

            Matrix A = new Matrix(1, 1);
            fillDataGridViewFromMatrix(MatrixA, A);
            fillDataGridViewFromMatrix(MatrixB, A);
        }

        #region DataGridView
        public static void fillDataGridViewFromMatrix(DataGridView D, Matrix A)
        {
            D.AllowUserToAddRows = true;
            D.Columns.Clear();
            D.Rows.Clear();
            for (int i = 0; i < A.m; i++)
            {
                var C = new DataGridViewColumn();
                //Здесь вид колонок

                C.Width = DefColumnWidth;
                C.CellTemplate = new DataGridViewTextBoxCell();

                D.Columns.Add(C);
            }
            for (int j = 0; j < A.n - 1; j++)
            {
                var R = new DataGridViewRow();
                //Здесь вид рядов

                R.Height = DefRowHeight;

                D.Rows.Add(R);
            }

            for (int i = 0; i < A.n; i++)
            {
                for (int j = 0; j < A.m; j++)
                {
                    D[j, i].Value = A.arr[i, j];
                }
            }
        }

        public static Matrix extractMatrix(DataGridView D)
        {
            Matrix R = new Matrix(D.Columns.Count, D.Rows.Count);
            for (int i = 0; i < D.Columns.Count; i++)
            {
                for (int j = 0; j < D.Rows.Count; j++)
                {
                    R.arr[i, j] = Convert.ToDouble(D[i, j].Value);
                }
            }
            return R.Transp();
        }

        public static void convertToDefaultView(DataGridView D)
        {
            D.AllowUserToResizeRows = false;
            D.AllowUserToResizeColumns = false;
            D.AllowUserToOrderColumns = false;
            D.ColumnHeadersVisible = false;
            D.RowHeadersVisible = false;
        }
        #endregion

        #region Data transformation
        //Resize A
        private void increaseN1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(N1.Text) < 20)
            {
                Matrix A = extractMatrix(MatrixA);
                A = A.AddRow();
                N1.Text = Convert.ToString((Convert.ToInt32(N1.Text)) + 1);
                fillDataGridViewFromMatrix(MatrixA, A);
            }
        }
        private void decreaseN1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(N1.Text) > 1)
            {
                Matrix A = extractMatrix(MatrixA);
                A = A.DelRow();
                N1.Text = Convert.ToString((Convert.ToInt32(N1.Text)) - 1);
                fillDataGridViewFromMatrix(MatrixA, A);
            }
        }
        private void increaseM1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(M1.Text) < 20)
            {
                Matrix A = extractMatrix(MatrixA);
                A = A.AddColumn();
                M1.Text = Convert.ToString((Convert.ToInt32(M1.Text)) + 1);
                fillDataGridViewFromMatrix(MatrixA, A);
            }
        }
        private void decreaseM1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(M1.Text) > 1)
            {
                Matrix A = extractMatrix(MatrixA);
                A = A.DelColumn();
                M1.Text = Convert.ToString((Convert.ToInt32(M1.Text)) - 1);
                fillDataGridViewFromMatrix(MatrixA, A);
            }
        }

        //Resize B
        private void increaseN2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(N2.Text) < 20)
            {
                Matrix A = extractMatrix(MatrixB);
                A = A.AddRow();
                N2.Text = Convert.ToString((Convert.ToInt32(N2.Text)) + 1);
                fillDataGridViewFromMatrix(MatrixB, A);
                MatrixB.Update();
            }
        }
        private void decreaseN2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(N2.Text) > 1)
            {
                Matrix A = extractMatrix(MatrixB);
                A = A.DelRow();
                N2.Text = Convert.ToString((Convert.ToInt32(N2.Text)) - 1);
                fillDataGridViewFromMatrix(MatrixB, A);
                MatrixB.Update();
            }
        }
        private void increaseM2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(M2.Text) < 20)
            {
                Matrix A = extractMatrix(MatrixB);
                A = A.AddColumn();
                M2.Text = Convert.ToString((Convert.ToInt32(M2.Text)) + 1);
                fillDataGridViewFromMatrix(MatrixB, A);
                MatrixB.Update();
            }
        }
        private void decreaseM2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(M2.Text) > 1)
            {
                Matrix A = extractMatrix(MatrixB);
                A = A.DelColumn();
                M2.Text = Convert.ToString((Convert.ToInt32(M2.Text)) - 1);
                fillDataGridViewFromMatrix(MatrixB, A);
                MatrixB.Update();
            }
        }

        private void ClearA_Click(object sender, EventArgs e)
        {
            Matrix A = new Matrix(Convert.ToInt32(N1.Text), Convert.ToInt32(M1.Text));
            fillDataGridViewFromMatrix(MatrixA, A);
        }

        private void ClearB_Click(object sender, EventArgs e)
        {
            Matrix A = new Matrix(Convert.ToInt32(N2.Text), Convert.ToInt32(M2.Text));
            fillDataGridViewFromMatrix(MatrixB, A);
        }
        #endregion


        #region Calculations
        //det A
        private void detA_Click(object sender, EventArgs e)
        {
            double res;
            try
            {
                res = extractMatrix(MatrixA).Det();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Определитель", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Определитель матрицы A: " + Convert.ToString(Math.Round(res, 3)), "Определитель", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //det B
        private void detB_Click(object sender, EventArgs e)
        {
            double res;
            try
            {
                res = extractMatrix(MatrixB).Det();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Определитель", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Определитель матрицы B: " + Convert.ToString(Math.Round(res, 3)), "Определитель", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void inverseA_Click(object sender, EventArgs e)
        {
            Matrix R;
            try
            {
                R = extractMatrix(MatrixA).Inverse();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Определитель", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dres = (new Form2(R)).ShowDialog();
            if (dres == DialogResult.Yes)
            {
                Buf = R;
            }
        }

        private void inverseB_Click(object sender, EventArgs e)
        {
            Matrix R;
            try
            {
                R = extractMatrix(MatrixB).Inverse();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Определитель", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dres = (new Form2(R)).ShowDialog();
            if (dres == DialogResult.Yes)
            {
                Buf = R;
            }
        }

        private void Apown_Click(object sender, EventArgs e)
        {
            Matrix R;
            double n;
            try
            {
                n = Convert.ToDouble(textBox1.Text);
                R = extractMatrix(MatrixA);
                R = R ^ n;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Недопустимые данные!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dres = (new Form2(R)).ShowDialog();
            if (dres == DialogResult.Yes)
            {
                Buf = R;
            }
        }

        private void Bpown_Click(object sender, EventArgs e)
        {
            Matrix R;
            double n;
            try
            {
                n = Convert.ToDouble(textBox1.Text);
                R = extractMatrix(MatrixB);
                R = R ^ n;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Недопустимые данные!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dres = (new Form2(R)).ShowDialog();
            if (dres == DialogResult.Yes)
            {
                Buf = R;
            }
        }

        private void Axn_Click(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(textBox1.Text);
            Matrix R = extractMatrix(MatrixA) * n;
            DialogResult dres = (new Form2(R)).ShowDialog();
            if (dres == DialogResult.Yes)
            {
                Buf = R;
            }
        }

        private void Bxn_Click(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(textBox1.Text);
            Matrix R = extractMatrix(MatrixB) * n;
            DialogResult dres = (new Form2(R)).ShowDialog();
            if (dres == DialogResult.Yes)
            {
                Buf = R;
            }
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Matrix R;
                try
                {
                    R = extractMatrix(MatrixA) + extractMatrix(MatrixB);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Недопустимые данные!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult dres = (new Form2(R)).ShowDialog();
                if (dres == DialogResult.Yes)
                {
                    Buf = R;
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                Matrix R;
                try
                {
                    R = extractMatrix(MatrixA) - extractMatrix(MatrixB);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Недопустимые данные!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult dres = (new Form2(R)).ShowDialog();
                if (dres == DialogResult.Yes)
                {
                    Buf = R;
                }
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                Matrix R;
                try
                {
                    R = extractMatrix(MatrixA) * extractMatrix(MatrixB);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Недопустимые данные!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult dres = (new Form2(R)).ShowDialog();
                if (dres == DialogResult.Yes)
                {
                    Buf = R;
                }
            }
        }

        #endregion

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9') // цифра
                return;
            if (e.KeyChar == '.')
                e.KeyChar = ',';
            if (e.KeyChar == ',')
            {
                if (textBox1.Text.IndexOf(',') != -1 || textBox1.Text.Length == 0)
                    e.Handled = true;
                return;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            e.Handled = true;
        }

        private void Matrix_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            ((DataGridView)sender).AllowUserToAddRows = false;
        }
    }
    public class Matrix
    {
        static public double accur = 0.000000001;
        public int n;
        public int m;
        public double[,] arr;

        #region Constructors
        public Matrix()
        {
            n = 0;
            m = 0;
            arr = null;
        }
        public Matrix(int n0, int m0)
        {
            n = n0;
            m = m0;
            arr = new double[n, m];
        }
        public Matrix(double[,] arr0)
        {
            n = arr0.GetLength(0);
            m = arr0.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = arr0[i, j];
                }
            }
        }
        #endregion
        #region Math methods
        //алгебраические дополнения
        public double A(int i0, int j0)
        {
            Matrix res = new Matrix(n - 1, m - 1);
            int k = 0, t = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i == i0 || j == j0)
                    {
                        continue;
                    }
                    else
                    {
                        res.arr[t, k] = arr[i, j];
                        if (k < n - 2)
                        {
                            k++;
                        }
                        else
                        {
                            k = 0;
                            t++;
                        }

                    }
                }
            }
            return res.Det() * Math.Pow(-1, (i0 + j0));
        }
        //обратная
        public Matrix Inverse()
        {
            Matrix res = new Matrix(n, m);
            double D = this.Det();
            if (D == 0)
            {
                throw new Exception("Вырожденная матрица!");
            }
            D = 1 / D;
            if (n == m && this.Det() != 0)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        res.arr[i, j] = A(i, j);
                    }
                }
            }
            else
            {
                throw new Exception("Для нахождения обратной матрицы нужно чтобы матрица была квадратной!");
            }
            res = res.Transp();
            res = res * D;
            return res;
        }
        public Matrix Transp()
        {
            Matrix res = new Matrix(m, n);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    res.arr[i, j] = arr[j, i];
                }
            }
            return res;
        }

        public double Det()
        {
            if (n != m)
            {
                throw new Exception("Для нахождения определителя матрица должна быть квадратной!");
            }
            else
            {
                double det = 1;
                const double EPS = 1E-9;
                double[][] a = this.convertTo2Ind();
                double[][] b = new double[1][];
                for (int i = 0; i < n; ++i)
                {
                    int k = i;
                    for (int j = i + 1; j < n; ++j)
                        if (Math.Abs(a[j][i]) > Math.Abs(a[k][i]))
                            k = j;
                    if (Math.Abs(a[k][i]) < EPS)
                    {
                        det = 0;
                        break;
                    }
                    b[0] = a[i];
                    a[i] = a[k];
                    a[k] = b[0];
                    if (i != k)
                        det = -det;
                    det *= a[i][i];
                    for (int j = i + 1; j < n; ++j)
                        a[i][j] /= a[i][i];
                    for (int j = 0; j < n; ++j)
                        if ((j != i) && (Math.Abs(a[j][i]) > EPS))
                            for (k = i + 1; k < n; ++k)
                                a[j][k] -= a[i][k] * a[j][i];
                }
                return det;
            }
        }
        #endregion
        #region Operators
        public static Matrix operator +(Matrix A, Matrix B)
        {
            if (A.n == B.n && A.m == B.m)
            {
                Matrix R = new Matrix(A.n, A.m);
                for (int i = 0; i < A.n; i++)
                {
                    for (int j = 0; j < A.m; j++)
                    {
                        R.arr[i, j] = A.arr[i, j] + B.arr[i, j];
                    }
                }
                return R;
            }
            else
            {
                throw new Exception("Для выполнения операции сложения размерности матриц должны совпадать!");
            }
        }
        public static Matrix operator -(Matrix A, Matrix B)
        {
            if (A.n == B.n && A.m == B.m)
            {
                Matrix R = new Matrix(A.n, A.m);
                for (int i = 0; i < A.n; i++)
                {
                    for (int j = 0; j < A.m; j++)
                    {
                        R.arr[i, j] = A.arr[i, j] - B.arr[i, j];
                    }
                }
                return R;
            }
            else
            {
                throw new Exception("Для выполнения операции вычитания размерности матриц должны совпадать!");
            }
        }
        public static Matrix operator *(Matrix A, Matrix B)
        {
            if (A.m == B.n)
            {
                Matrix R = new Matrix(A.n, B.m);

                for (int i = 0; i < A.n; i++)
                {
                    for (int j = 0; j < B.m; j++)
                    {
                        for (int k = 0; k < B.n; k++)
                        {
                            R.arr[i, j] += A.arr[i, k] * B.arr[k, j];
                        }
                    }
                }

                return Matrix.ZeroAnalysis(R);
            }
            else
            {
                throw new Exception("Для выполнения операции умножения матрицы должны быть совместимы (Am = Bn)!");
            }
        }
        public static Matrix operator ^(Matrix A, double deg)
        {
            if (deg <= 0)
            {
                throw new Exception("Не натуральный показатель!");
            }
            if (deg - Math.Truncate(deg) != 0)
            {
                throw new Exception("Не натуральный показатель!");
            }
            if (A.n == A.m)
            {
                deg--;
                Matrix R = A;
                for (int i = 0; i < deg; i++)
                {
                    R = R * R;
                }
                return R;
            }
            else
            {
                throw new Exception("Для возведения матрицы в степень матрица должна быть квадратной!");
            }
        }
        public static Matrix operator *(Matrix A, double k)
        {
            Matrix R = new Matrix(A.n, A.m);
            for (int i = 0; i < R.n; i++)
            {
                for (int j = 0; j < R.m; j++)
                {
                    R.arr[i, j] = A.arr[i, j] * k;
                }
            }
            return R;
        }
        #endregion

        #region Resize
        public Matrix AddColumn()
        {
            Matrix R = new Matrix(n, m + 1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    R.arr[i, j] = arr[i, j];
                }
            }
            return R;
        }
        public Matrix AddRow()
        {
            Matrix R = new Matrix(n + 1, m);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    R.arr[i, j] = arr[i, j];
                }
            }
            return R;
        }
        public Matrix DelColumn()
        {
            Matrix R = new Matrix(n, m - 1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m - 1; j++)
                {
                    R.arr[i, j] = arr[i, j];
                }
            }
            return R;
        }
        public Matrix DelRow()
        {
            Matrix R = new Matrix(n - 1, m);
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    R.arr[i, j] = arr[i, j];
                }
            }
            return R;
        }
        #endregion

        public double[][] convertTo2Ind()
        {
            double[][] res = new double[arr.GetLength(0)][];
            for (int i = 0; i < res.GetLength(0); i++)
            {
                res[i] = new double[arr.GetLength(1)];
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    res[i][j] = arr[i, j];
                }
            }
            return res;
        }

        public string ToString()
        {
            string matr = "";
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matr += Convert.ToString(Math.Round(arr[i, j], 3)) + " \t";
                }
                matr += "\n\n";
            }
            return matr;
        }

        static public Matrix ZeroAnalysis(Matrix A)
        {
            Matrix R = A;
            for (int i = 0; i < R.n; i++)
            {
                for (int j = 0; j < R.m; j++)
                {
                    if (R.arr[i, j] < accur)
                    {
                        R.arr[i, j] = 0;
                    }
                }
            }
            return R;
        }
    }
}