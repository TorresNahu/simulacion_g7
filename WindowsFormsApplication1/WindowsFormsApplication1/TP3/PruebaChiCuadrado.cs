using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_G7.TP3
{
    class PruebaChiCuadrado
    {
        double[] chi_095 = { 0, 3.84, 5.99, 7.81, 9.49, 11.1, 12.6, 14.1, 15.5, 16.9, 18.3, 19.7, 21.0, 22.4, 23.7, 25.0, 26.3, 27.6, 28.9, 30.1, 31.4, 32.7, 33.9, 35.2, 36.4, 37.7, 38.9, 40.1, 41.3, 42.6, 43.8 };

        //--------------------------------------------------------------------------------------------------------------------------------------
        //Uniforme
        double frec_esp_uniforme;
        double error_rel_uniforme;
        int grLibertad_uniforme;
        int[] lista_frecuencias;

        //float ancho_intervalo;
        //float max_valor;
        //float min_valor;

        private double calculoFrecEsperadaUniforme(int intervalos, int cantidadNum)
        {
            //double rango = (1.0 / intervalos);
            frec_esp_uniforme = cantidadNum / intervalos;

            return frec_esp_uniforme;
        }
        private int gradosLibertadUniforme(int intervalos)
        {
            grLibertad_uniforme = intervalos - 1;
            return grLibertad_uniforme;
        }
        private int[] armarListaFrecuenciasUniforme(double[] lista, int cantidadNum, int intervalos, double lim_inf, double lim_sup)
        {
            //int posicion;
            double ancho_intervalo = 1.0 / intervalos;
            lista_frecuencias = new int[intervalos];

            //for (int i = 0; i < cantidadNum; i++)
            //{
            //    if (i == 0)
            //    {
            //        max_valor = (float)lista[i];
            //        min_valor = (float)lista[i];
            //    }
            //    else if (max_valor < lista[i])
            //    {
            //        max_valor = (float)lista[i];
            //    }
            //    else if (min_valor > lista[i])
            //    {
            //        min_valor = (float)lista[i];
            //    }
            //}
            //ancho_intervalo = (max_valor - min_valor) / intervalos;
            //for (int i = 0; i < lista.Length; i++)
            //{
            //    posicion = (int)((lista[i] - min_valor) / ancho_intervalo);
            //    if (posicion == intervalos)
            //    {
            //        posicion = posicion - 1;
            //    }
            //    lista_frecuencias[posicion] += 1;

            //}
            lim_sup = lim_inf + ancho_intervalo;
            for (int i = 0; i < intervalos; i++)
            {
                for (int j = 0; j < lista.Length; j++)
                {
                    if (lista[j] > lim_inf && lista[j] <= lim_sup)
                    {
                        lista_frecuencias[i]++;
                    }
                }
                lim_inf = lim_sup;
                lim_sup = lim_inf + ancho_intervalo;
            }
            return lista_frecuencias;
        }
        private double calcularErrorRelativoUniforme(int[] lista_frecuencias)
        {
            double aux1 = 0.0;
            double aux2 = 0.0;

            for (int i = 0; i < lista_frecuencias.Length; i++)
            {
                aux1 = lista_frecuencias[i] - frec_esp_uniforme;
                aux2 = Math.Pow(aux1, 2);
                error_rel_uniforme += aux2 / frec_esp_uniforme;
            }
            return error_rel_uniforme;
        }
        public String calcularHipotesisUniforme(double liminf, double limsup, int intervalos, int cantidadNum, double[] lista)
        {
            //Chi hasta 30 grados de libertad
            calculoFrecEsperadaUniforme(intervalos, cantidadNum);
            armarListaFrecuenciasUniforme(lista, cantidadNum, intervalos, liminf, limsup);
            calcularErrorRelativoUniforme(lista_frecuencias);
            gradosLibertadUniforme(intervalos);
            double errTabUnif;
            errTabUnif = chi_095[grLibertad_uniforme];
            string str = "Error calculado: " + error_rel_uniforme + "\nError Tabulado: " + errTabUnif + "\nNo Aceptamos";
            if (error_rel_uniforme < errTabUnif)
            {
                str = "Error calculado: " + error_rel_uniforme + "\nError Tabulado: " + errTabUnif + "\nAceptamos";
            }
            return str;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------
        //Exponencial
        double[] lista_frec_esp_exp;
        double error_rel_exp;
        int grLibertad_exp;
        int[] lista_frecuenciasExp;

        private int[] armarListaFrecuenciasExponencial(double[] lista, int cantidadNum, int intervalos, int min, int max)
        {
            //int posicion;
            //double ancho_intervalo = 1.0 / intervalos;
            float ancho_intervalo = (max - min) / (float)intervalos;
            float lim_inf = min;
            float lim_sup = min;

            lista_frecuenciasExp = new int[intervalos];

            lim_sup = lim_inf + ancho_intervalo;
            for (int i = 0; i < intervalos; i++)
            {
                for (int j = 0; j < lista.Length; j++)
                {
                    if (lista[j] > lim_inf && lista[j] <= lim_sup)
                    {
                        lista_frecuenciasExp[i]++;
                    }
                }
                lim_inf = lim_sup;
                lim_sup = lim_inf + ancho_intervalo;
            }
            return lista_frecuenciasExp;
        }
        private double[] calculoFrecEsperadaExponencial(int intervalos, int cantidadNum, float lambda, int min, int max)
        {
            lista_frec_esp_exp = new double[intervalos];
            //Hay que calcular la probabilidad esperada.
            float ancho_intervalo = (max - min) / (float)intervalos;
            double prob_esperada;
            double marca;
            double limInf = min;
            double limSup = min + ancho_intervalo;
            for (int i = 0; i < intervalos; i++)
            {
                marca = (limSup + limInf) / 2.0;
                prob_esperada = lambda * Math.Exp(-lambda * marca) * (limSup - limInf);

                lista_frec_esp_exp[i] = prob_esperada * cantidadNum;

                limInf = limSup;
                limSup = limSup + ancho_intervalo;
            }

            return lista_frec_esp_exp;
        }
        private int gradosLibertadExponencial(int intervalos, int cantDatosEmpiricos)
        {
            return grLibertad_exp = intervalos - 1 - cantDatosEmpiricos;
        }
        private double calcularErrorRelativoExponencial(int[] lista_frecuencias)
        {
            double var_frec_esp_exp = lista_frec_esp_exp[0];
            int var_frec_obt_exp = lista_frecuenciasExp[0];

            List<double> Lista_Frec_Esperada_Exp = new List<double>();
            List<int> Lista_Frec_Obtenida_Exp = new List<int>();

            double aux1;
            double aux2;
            int index = 0;

            for (int i = 0; i < lista_frecuenciasExp.Length; i++)
            {
                //Si es menor a 5 le suma el siguiente.
                if (var_frec_esp_exp < 5 && i != (lista_frecuenciasExp.Length - 1))
                {
                    var_frec_esp_exp += lista_frec_esp_exp[i + 1];
                    var_frec_obt_exp += lista_frecuenciasExp[i + 1];

                }
                //Si es mayor a 5 entra y prepara el siguiente.
                else if (var_frec_esp_exp >= 5 && i != (lista_frecuenciasExp.Length - 1))
                {
                    Lista_Frec_Esperada_Exp.Insert(index, var_frec_esp_exp);
                    Lista_Frec_Obtenida_Exp.Insert(index, var_frec_obt_exp);
                    index++;

                    var_frec_esp_exp = lista_frec_esp_exp[i + 1];
                    var_frec_obt_exp = lista_frecuenciasExp[i + 1];
                }
                //Si es menor a 5 y es el ultimo intervalo se lo sumamos al anterior.
                else if (var_frec_esp_exp < 5 && i == (lista_frecuenciasExp.Length - 1))
                {
                    index--;

                    var_frec_esp_exp += double.Parse(Lista_Frec_Esperada_Exp[index].ToString());
                    var_frec_obt_exp += int.Parse(Lista_Frec_Obtenida_Exp[index].ToString());

                    Lista_Frec_Esperada_Exp.RemoveAt(index);
                    Lista_Frec_Obtenida_Exp.RemoveAt(index);
                    Lista_Frec_Esperada_Exp.Insert(index, var_frec_esp_exp);
                    Lista_Frec_Obtenida_Exp.Insert(index, var_frec_obt_exp);
                }
                //Si es mayor a 5 y es el ultimo intervalo, no prepara al siguiente.
                else if (var_frec_esp_exp >= 5 && i == (lista_frecuenciasExp.Length - 1))
                {
                    Lista_Frec_Esperada_Exp.Insert(index, var_frec_esp_exp);
                    Lista_Frec_Obtenida_Exp.Insert(index, var_frec_obt_exp);
                }
            }

            // Aca se calcula el error
            for (int i = 0; i < Lista_Frec_Esperada_Exp.Count; i++)
            {
                aux1 = Lista_Frec_Esperada_Exp[i] - Lista_Frec_Obtenida_Exp[i];

                aux2 = Math.Pow(aux1, 2);

                error_rel_exp += (aux2 / Lista_Frec_Esperada_Exp[i]);
            }

            return error_rel_exp;
        }
        public string calcularHipotesisExponencial(double[] listaNumeros, int intervalos, int cantidadNum, float lambda, int min, int max)
        {
            //Chi hasta 30 grados de libertad
            armarListaFrecuenciasExponencial(listaNumeros, cantidadNum, intervalos, min, max);
            calculoFrecEsperadaExponencial(intervalos, cantidadNum, lambda, min, max);
            calcularErrorRelativoExponencial(lista_frecuencias);
            gradosLibertadExponencial(intervalos, 1);
            double errTabExp;
            errTabExp = chi_095[grLibertad_exp];
            string str = "Error calculado: " + error_rel_exp + "\nError Tabulado: " + errTabExp + "\nNo Aceptamos";


            if (error_rel_exp < errTabExp)
            {
                str = "Error calculado: " + error_rel_exp + "\nError Tabulado: " + errTabExp + "\nAceptamos";
            }

            return str;
        }


        //--------------------------------------------------------------------------------------------------------------------------------------
        //Poisson
        double[] lista_frec_esp_poisson;
        double error_rel_poisson;
        int grLibertad_poisson;
        int[] lista_frecuenciasPoisson;
        double prob_esperada;

        protected int carcularFactorial(int num)
        {
            int resultado = 1;
            for (int i = 1; i <= num; i++)
            {
                resultado = resultado * i;
            }

            return resultado;
        }

        private int[] armarListaFrecuenciasPoisson(double[] lista, int cantidadNum, int intervalos, int min, int max)
        {
            float ancho_intervalo1 = (max - min) / (float)intervalos;
            int ancho_intervalo2 = (int)Math.Ceiling(ancho_intervalo1);
            int lim_inf = min;
            int lim_sup = min;

            lista_frecuenciasPoisson = new int[intervalos];

            lim_sup = lim_inf + ancho_intervalo2;
            for (int i = 0; i < intervalos; i++)
            {
                for (int j = 0; j < lista.Length; j++)
                {
                    if (lista[j] >= lim_inf && lista[j] <= lim_sup)
                    {
                        lista_frecuenciasPoisson[i]++;
                    }
                }
                lim_inf = lim_sup + 1;
                lim_sup = lim_sup + 1 + ancho_intervalo2;
            }
            return lista_frecuenciasPoisson;
        }
        private double[] calculoFrecEsperadaPoisson(int intervalos, int cantidadNum, double lambda, int min, int max)
        {
            lista_frec_esp_poisson = new double[intervalos];
            float ancho_intervalo1 = (max - min) / (float)intervalos;
            int ancho_intervalo2 = (int)Math.Ceiling(ancho_intervalo1);
            int limInf = min;
            int limSup = min + ancho_intervalo2;
            double aux1;
            double aux2;
            double aux3;

            for (int i = 0; i < intervalos; i++)
            {
                for (int j = limInf; j <= limSup; j++)
                {
                    int factorial = carcularFactorial(j);
                    aux1 = Math.Exp(-lambda);
                    aux2 = Math.Pow(lambda, j);
                    aux3 = (aux1 * aux2) / factorial;
                    prob_esperada += aux3;
                }

                lista_frec_esp_poisson[i] = prob_esperada * cantidadNum;

                limInf = limSup + 1;
                limSup = limSup + 1 + ancho_intervalo2;
                prob_esperada = 0;
            }

            return lista_frec_esp_poisson;
        }
        private int gradosLibertadPoisson(int intervalos, int cantDatosEmpiricos)
        {
            return grLibertad_poisson = intervalos - 1 - cantDatosEmpiricos;

        }
        private double calcularErrorRelativoPoisson(int[] lista_frecuencias)
        {
            double var_frec_esp_poisson = lista_frec_esp_poisson[0];
            int var_frec_obt_poisson = lista_frecuenciasPoisson[0];

            List<double> Lista_Frec_Esperada_Poisson = new List<double>();
            List<int> Lista_Frec_Obtenida_Poisson = new List<int>();

            double aux1;
            double aux2;
            int index = 0;

            for (int i = 0; i < lista_frecuenciasPoisson.Length; i++)
            {
                //Si es menor a 5 le suma el siguiente.
                if (var_frec_esp_poisson < 5 && i != (lista_frecuenciasPoisson.Length - 1))
                {
                    var_frec_esp_poisson += lista_frec_esp_poisson[i + 1];
                    var_frec_obt_poisson += lista_frecuenciasPoisson[i + 1];

                }
                //Si es mayor a 5 entra y prepara el siguiente.
                else if (var_frec_esp_poisson >= 5 && i != (lista_frecuenciasPoisson.Length - 1))
                {
                    Lista_Frec_Esperada_Poisson.Insert(index, var_frec_esp_poisson);
                    Lista_Frec_Obtenida_Poisson.Insert(index, var_frec_obt_poisson);
                    index++;

                    var_frec_esp_poisson = lista_frec_esp_poisson[i + 1];
                    var_frec_obt_poisson = lista_frecuenciasPoisson[i + 1];
                }
                //Si es menor a 5 y es el ultimo intervalo se lo sumamos al anterior.
                else if (var_frec_esp_poisson < 5 && i == (lista_frecuenciasPoisson.Length - 1))
                {
                    index--;

                    var_frec_esp_poisson += double.Parse(Lista_Frec_Esperada_Poisson[index].ToString());
                    var_frec_obt_poisson += int.Parse(Lista_Frec_Obtenida_Poisson[index].ToString());

                    Lista_Frec_Esperada_Poisson.RemoveAt(index);
                    Lista_Frec_Obtenida_Poisson.RemoveAt(index);
                    Lista_Frec_Esperada_Poisson.Insert(index, var_frec_esp_poisson);
                    Lista_Frec_Obtenida_Poisson.Insert(index, var_frec_obt_poisson);
                }
                //Si es mayor a 5 y es el ultimo intervalo, no prepara al siguiente.
                else if (var_frec_esp_poisson >= 5 && i == (lista_frecuenciasPoisson.Length - 1))
                {
                    Lista_Frec_Esperada_Poisson.Insert(index, var_frec_esp_poisson);
                    Lista_Frec_Obtenida_Poisson.Insert(index, var_frec_obt_poisson);
                }
            }

            // Aca se calcula el error
            for (int i = 0; i < Lista_Frec_Esperada_Poisson.Count; i++)
            {
                aux1 = Lista_Frec_Obtenida_Poisson[i] - Lista_Frec_Esperada_Poisson[i];

                aux2 = Math.Pow(aux1, 2);

                error_rel_poisson += (aux2 / Lista_Frec_Esperada_Poisson[i]);
            }

            return error_rel_poisson;
        }
        public string calcularHipotesisPoisson(double[] lista_Numeros, int intervalos, int cantidadNum, float lambda, int min, int max)
        {
            //Chi hasta 30 grados de libertad
            armarListaFrecuenciasPoisson(lista_Numeros, cantidadNum, intervalos, min, max);
            calculoFrecEsperadaPoisson(intervalos, cantidadNum, lambda, min, max);
            calcularErrorRelativoPoisson(lista_frecuencias);
            gradosLibertadPoisson(intervalos, 1);

            double errTabPoisson;
            errTabPoisson = chi_095[grLibertad_poisson];

            string str = "Error calculado: " + error_rel_poisson + "\nError Tabulado: " + errTabPoisson + "\nNo Aceptamos";


            if (error_rel_poisson < errTabPoisson)
            {
                str = "Error calculado: " + error_rel_poisson + "\nError Tabulado: " + errTabPoisson + "\nAceptamos";
            }

            return str;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------
        //Normal
        double[] lista_frec_esp_normal;
        double error_rel_normal;
        int[] lista_frecuenciasNormal;
        int grLibertad_normal;

        private int[] armarListaFrecuenciasNormal(double[] lista, int cantidadNum, int intervalos, int min, int max)
        {
            //int posicion;
            //double ancho_intervalo = 1.0 / intervalos;
            float ancho_intervalo = (max - min) / (float)intervalos;
            float lim_inf = min;
            float lim_sup = min;

            lista_frecuenciasNormal = new int[intervalos];

            lim_sup = lim_inf + ancho_intervalo;
            for (int i = 0; i < intervalos; i++)
            {
                for (int j = 0; j < lista.Length; j++)
                {
                    if (lista[j] > lim_inf && lista[j] <= lim_sup)
                    {
                        lista_frecuenciasNormal[i]++;
                    }
                }
                lim_inf = lim_sup;
                lim_sup = lim_inf + ancho_intervalo;
            }
            return lista_frecuenciasNormal;
        }
        private double[] calculoFrecEsperadaNormal(int intervalos, float media, float desv_estandar, int cant_Numeros, int min, int max)
        {
            lista_frec_esp_normal = new double[intervalos];
            float ancho_intervalo = (max - min) / (float)intervalos;
            float lim_inf = min;
            float lim_sup = min;

            double aux1 = -1 / 2.0;

            lim_sup = lim_inf + ancho_intervalo;

            double fm;
            double fm_ancho;
            double marca;
            double frec_esp_normal;

            for (int i = 0; i < intervalos; i++)
            {
                marca = ((lim_sup + lim_inf) / 2.0);

                fm = (Math.Exp(aux1 * (Math.Pow(((marca - media) / desv_estandar), 2)))) / (desv_estandar * Math.Sqrt(2 * Math.PI));
                fm_ancho = fm * (lim_sup - lim_inf);
                frec_esp_normal = fm_ancho * cant_Numeros;

                lista_frec_esp_normal[i] = frec_esp_normal;

                lim_inf = lim_sup;
                lim_sup = lim_inf + ancho_intervalo;
            }

            return lista_frec_esp_normal;
        }
        private int gradosLibertadNormal(int intervalos, int cantDatosEmpiricos)
        {
            return grLibertad_normal = intervalos - 1 - cantDatosEmpiricos;
        }
        private double calcularErrorRelativoNormal(int[] lista_frecuenciasNormal)
        {
            double var_frec_esp_normal = lista_frec_esp_normal[0];
            int var_frec_obt_normal = lista_frecuenciasNormal[0];

            List<double> Lista_Frec_Esperada_Normal = new List<double>();
            List<int> Lista_Frec_Obtenida_Normal = new List<int>();

            double aux1;
            double aux2;
            int index = 0;

            for (int i = 0; i < lista_frecuenciasNormal.Length; i++)
            {
                //Si es menor a 5 le suma el siguiente.
                if (var_frec_esp_normal < 5 && i != (lista_frecuenciasNormal.Length - 1))
                {
                    var_frec_esp_normal += lista_frec_esp_normal[i + 1];
                    var_frec_obt_normal += lista_frecuenciasNormal[i + 1];

                }
                //Si es mayor a 5 entra y prepara el siguiente.
                else if (var_frec_esp_normal >= 5 && i != (lista_frecuenciasNormal.Length - 1))
                {
                    Lista_Frec_Esperada_Normal.Insert(index, var_frec_esp_normal);
                    Lista_Frec_Obtenida_Normal.Insert(index, var_frec_obt_normal);
                    index++;

                    var_frec_esp_normal = lista_frec_esp_normal[i + 1];
                    var_frec_obt_normal = lista_frecuenciasNormal[i + 1];
                }
                //Si es menor a 5 y es el ultimo intervalo se lo sumamos al anterior.
                else if (var_frec_esp_normal < 5 && i == (lista_frecuenciasNormal.Length - 1))
                {
                    index--;

                    var_frec_esp_normal += double.Parse(Lista_Frec_Esperada_Normal[index].ToString());
                    var_frec_obt_normal += int.Parse(Lista_Frec_Obtenida_Normal[index].ToString());

                    Lista_Frec_Esperada_Normal.RemoveAt(index);
                    Lista_Frec_Obtenida_Normal.RemoveAt(index);
                    Lista_Frec_Esperada_Normal.Insert(index, var_frec_esp_normal);
                    Lista_Frec_Obtenida_Normal.Insert(index, var_frec_obt_normal);
                }
                //Si es mayor a 5 y es el ultimo intervalo, no prepara al siguiente.
                else if (var_frec_esp_normal >= 5 && i == (lista_frecuenciasNormal.Length - 1))
                {
                    Lista_Frec_Esperada_Normal.Insert(index, var_frec_esp_normal);
                    Lista_Frec_Obtenida_Normal.Insert(index, var_frec_obt_normal);
                }
            }

            // Aca se calcula el error
            for (int i = 0; i < Lista_Frec_Esperada_Normal.Count; i++)
            {
                aux1 = Lista_Frec_Obtenida_Normal[i] - Lista_Frec_Esperada_Normal[i];

                aux2 = Math.Pow(aux1, 2);

                error_rel_normal += (aux2 / Lista_Frec_Esperada_Normal[i]);
            }

            return error_rel_normal;
        }
        public string calcularHipotesisNormal(double[] listaNumeros, int intervalos, int cantidadNum, float media, float desv_estandar, int min, int max)
        {
            //Chi hasta 30 grados de libertad            
            armarListaFrecuenciasNormal(listaNumeros, cantidadNum, intervalos, min, max);
            calculoFrecEsperadaNormal(intervalos, media, desv_estandar, cantidadNum, min, max);
            calcularErrorRelativoNormal(lista_frecuenciasNormal);
            gradosLibertadNormal(intervalos, 2);
            double errTabNormal;
            errTabNormal = chi_095[grLibertad_normal];

            string str = "Error calculado: " + error_rel_normal + "\nError Tabulado: " + errTabNormal + "\nNo Aceptamos";

            if (error_rel_normal < errTabNormal)
            {
                str = "Error calculado: " + error_rel_normal + "\nError Tabulado: " + errTabNormal + "\nAceptamos";
            }

            return str;
        }

    }
}
