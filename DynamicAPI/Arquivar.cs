using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.IO;

namespace DynamicAPI {
    public static class Arquivar {

        private static FileStream fs;
        private static string fPath = "Arquivos/";

        public static bool SalvarPessoa(JObject p) {

            //string pessoa = p.ToString();
            string pessoa = JsonConvert.SerializeObject(p);

            if (!File.Exists(fPath + "pessoas.txt")) {

                try {

                    fs = File.Create(fPath + "pessoas.txt");
                    fs.Close();

                }
                catch {
                    throw new Exception();
                }
            }

            try {

                File.AppendAllText(fPath + "pessoas.txt", pessoa + Environment.NewLine);
            }
            catch {
                throw new Exception();
            }

            return true;
        
        }

        public static bool SalvarSetor(JObject s) {

            string setor = JsonConvert.SerializeObject(s);

            if (!File.Exists(fPath + "setores.txt")) {

                try {

                    fs = File.Create(fPath + "setores.txt");
                    fs.Close();

                }
                catch {
                    throw new Exception();
                }
            }

            try {

                File.AppendAllText(fPath + "setores.txt", setor + Environment.NewLine);
            }
            catch {
                throw new Exception();
            }

            return true;

        }

        public static bool SalvarEmpresa(JObject e) {

            string empresa = JsonConvert.SerializeObject(e);

            if (!File.Exists(fPath + "empresas.txt")) {

                try {

                    fs = File.Create(fPath + "empresas.txt");
                    fs.Close();

                }
                catch {
                    throw new Exception();
                }
            }

            try {

                File.AppendAllText(fPath + "empresas.txt", empresa + Environment.NewLine);
            }
            catch {
                throw new Exception();
            }

            return true;

        }

    }
}
