using System;
using System.Collections.Generic;
using System.IO;

using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Markirator
{
    class Mkr
    {
        private string _path;
        private const int _columnsCount = 7;
        private bool _isOK = true;
        private Exception _ex;

        private List<int> _num;
        private List<string> _model;
        private List<string> _type;
        private List<string> _furType;
        private List<string> _furColor;
        private List<int> _size;
        private List<bool> _isPainted;

        // класс, содержащий информацию и необходимые данные
        //    о маркируемых шубах в данный момент


        public Mkr()
        {
            _path = String.Format("{0}\\Marking{1}-{2}-{3}_{4}-{5}.mkr", Paths.Default.DataFolderPath, DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute);
            init(_path);
        }

        public Mkr(string path)
        {
            _path = path;
            init(path);
        }

        private void init(string path)
        {
            _num = new List<int>();
            _model = new List<string>();
            _type = new List<string>();
            _furType = new List<string>();
            _furColor = new List<string>();
            _isPainted = new List<bool>();
            _size = new List<int>();

            try
            {

                if (!File.Exists(path))
                {
                    StreamWriter sw = new StreamWriter(path, false, Encoding.Unicode);
                    sw.Close();
                }
                StreamReader sr = new StreamReader(path);


                int c = 0;
                


                while (!sr.EndOfStream)
                {
                    string str = sr.ReadLine();
                    string[] arr = str.Split('#');

                    //num model type ftype furcolor size ispainted

                    Num(c, Int16.Parse(arr[0]));
                    Model(c, arr[1]);
                    Type(c,arr[2]);
                    FurType(c,arr[3]);
                    FurColor(c,arr[4]);
                    Size(c,Int16.Parse(arr[5]));
                    IsPainted(c,Boolean.Parse(arr[6]));

                    c++;
                }

                sr.Close();

            }
            catch (Exception ex)
            {
                _isOK = false;
                _ex = ex;

            }


        }

        public void Num(int i, int t)
        {
            if (_num.Count <= i)
                _num.Add(t);
            else
            _num[i] = t;

        }
        public int Num(int i)
        {
            return _num[i];
        }


        public void Model(int i, string t)
        {
            if (_model.Count <= i)
                _model.Add(t);
            else
                _model[i] = t;
        }
        public string Model(int i)
        {
            return _model[i];
        }

        public void Type(int i, string t)
        {
            if (_type.Count <= i)
                _type.Add(t);
            else
                _type[i] = t;
        }
        public string Type(int i)
        {
            return _type[i];
        }

        public void FurType(int i, string t)
        {

            if (_furType.Count <= i)
                _furType.Add(t);
            else
                _furType[i] = t;
        }
        public string FurType(int i)
        {
            return _furType[i];
        }

        public void FurColor(int i, string t)
        {
            if (_furColor.Count <= i)
                _furColor.Add(t);
            else
            _furColor[i] = t;
        }
        public string FurColor(int i)
        {
            return _furColor[i];
        }

        public void IsPainted(int i, bool t)
        {
            if (_isPainted.Count <= i)
                _isPainted.Add(t);
            else
                _isPainted[i] = t;
        }
        public void IsPainted(int i, string t)
        {
            t.ToUpper();
            bool rly = false;
            if (
                (t == "ДА") ||
                (t == "КРАШЕНЫЙ") ||
                (t == "КРАШЕННЫЙ") ||
                (t == "КРАШ") ||
                (t == "КР")
                )
                rly = true;
            if (_isPainted.Count <= i)
                _isPainted.Add(rly);
            else
                _isPainted[i] = rly;
        }
        public bool IsPainted(int i)
        {
            return _isPainted[i];
        }

        public void Size(int i, int t)
        {
            if (_size.Count <= i)
                _size.Add(t);
            else
                _size[i] = t;
        }
        public void Size(int i, string t)
        {
            bool check = false;
            int res = 0;
            if (_size.Count <= i)
            {
                check = (Int32.TryParse(t, out res));
                if (check) _size.Add(res);
                else _size.Add(0);
            }
            else
            {
                check = Int32.TryParse(t, out res);
                if (check) _size.Add(res);
                else _size[i]=0;
            }


        }
        public int Size(int i)
        {
            return _size[i];
        }

        public bool IsOK
        {
            get { return _isOK; }
        }
        public Exception Ex
        {
            get { return _ex; }
        }

        public int RowsCount
        {
            get { return _num.Count; }
        }
        public int ColumnsCount
        {
            get { return _columnsCount; }
        }

        public object[] ObjRow(int i)
        {
            object[] par = new object[ColumnsCount+1]; //чтобы в первую колонку картиночка влезала
            par[1] = Num(i);
            par[2] = Model(i);
            par[3] = Type(i);
            par[4] = FurType(i);
            par[5] = FurColor(i);
            par[6] = IsPainted(i);
            par[7] = Size(i);
            return par;

        }

        public int Count
        {
            get { return _num.Count; }
        }



        public void SetNewRow(string token)
        {
            try
            {
                string[] buf = token.Split(' ');
                string[] arr = new string[6];

                int c = buf.Length;

                for (int j = 5; j > c; j--)
                    arr[j] = "";

                int i = Count;
                Num(i, i);

                

             
                Model(i, arr[0]);
                Type(i, arr[1]);
                FurType(i, arr[2]);
                FurColor(i, arr[3]);
                IsPainted(i, arr[4]);
                Size(i, arr[5]);



            }
            catch (Exception ex)
            {
                _isOK = false;
                _ex = ex;
            }
        }
    }

}
