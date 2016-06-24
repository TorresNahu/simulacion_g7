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

        private double[] calculoFrecEsperadaExponencial(int intervalos, int cantidadNum, float lambda, float min_valor, float ancho_int)
        {
            lista_frec_esp_exp = new double[intervalos];
            //Hay que calcular la probabilidad esperada.
            float prob_esperada;
            float int_de_clase;
            float limInf = min_valor;
            float limSup = min_valor + ancho_int;
            for (int i = 0; i < lista_frec_esp_exp.Length; i++)
            {
                int_de_clase = (limSup + limInf) / 2;
                prob_esperada = lambda * (float)Math.Exp(-lambda * int_de_clase) * (limSup - limInf);

                lista_frec_esp_exp[i] = prob_esperada * cantidadNum;

                limInf = limSup;
                limSup = limSup + ancho_int;
            }

            return lista_frec_esp_exp;
        }
        private int gradosLibertadExponencial(int intervalos, int cantDatosEmpiricos)
        {
            grLibertad_exp = intervalos - 1 - cantDatosEmpiricos;
            return grLibertad_exp;
        }
        private double calcularErrorRelativoExponencial(int[] lista_frecuencias)
        {
            //double frec_esp = frec_esp_exp[0];
            //int frec_obt = lista_frecuencias[0];
            double aux1;
            double aux2;

            for (int i = 0; i < lista_frecuencias.Length; i++)
            {
                double frec_esp = lista_frec_esp_exp[i];
                int frec_obt = lista_frecuencias[i];
                if (frec_esp >= 5 && i != (lista_frecuencias.Length - 1))//Si es mayor a 5 entra y prepara el siguiente.
                {
                    aux1 = frec_obt - frec_esp;
                    aux2 = Math.Pow(aux1, 2);
                    error_rel_exp += aux2 / frec_esp;

                    //frec_esp = frec_esp_exp[i + 1];
                    //frec_obt = lista_frecuencias[i + 1];
                }
                else if (frec_esp < 5 && i != (lista_frecuencias.Length - 1))//Si es menor a 5 le suma el siguiente.
                {
                    frec_esp = lista_frec_esp_exp[i] + lista_frec_esp_exp[i + 1];
                    frec_obt = lista_frecuencias[i] + lista_frecuencias[i + 1];
                }
                else if (frec_esp < 5 && i == (lista_frecuencias.Length - 1))//Si es menor a 5 y es el ultimo intervalo se lo sumamos al anterior.
                {
                    frec_esp = lista_frec_esp_exp[i - 1] + lista_frec_esp_exp[i];
                    frec_obt = lista_frecuencias[i - 1] + lista_frecuencias[i];
                }
                else if (frec_esp >= 5 && i == (lista_frecuencias.Length - 1))//Si es mayor a 5 y es el ultimo intervalo, no prepara al siguiente.
                {
                    aux1 = frec_obt - frec_esp;
                    aux2 = Math.Pow(aux1, 2);
                    error_rel_exp += aux2 / frec_esp;
                }
            }
            return error_rel_exp;
        }
        public String calcularHipotesisExponencial(int intervalos, int cantidadNum, float lambda, int cantDatosEmp, int[] lista_frecuencias, float minimo_valor, float ancho_intervalo)
        {
            //Chi hasta 30 grados de libertad
            calculoFrecEsperadaExponencial(intervalos, cantidadNum, lambda, minimo_valor, ancho_intervalo);
            calcularErrorRelativoExponencial(lista_frecuencias);
            gradosLibertadExponencial(intervalos, cantDatosEmp);
            double errTabExp;
            errTabExp = chi_095[grLibertad_exp];
            string str = "Error calculado: " + error_rel_exp + "\nError Tabulado: " + errTabExp + "\nNo Aceptamos";


            if (error_rel_exp < errTabExp)
            {
                str = "Error calculado: " + error_rel_exp + "\nError Tabulado: " + errTabExp + "\nAceptamos";
            }

            return str;
        }

        /*
        //--------------------------------------------------------------------------------------------------------------------------------------
        //Poisson
        double[] frec_esp_poisson;
        double error_rel_poisson;
        int grLibertad_poisson;

        private double[] calculoFrecEsperadaPoisson(int intervalos, int cantidadNum, float lambda, float min_valor, float ancho_int)
        {
            frec_esp_poisson = new double[intervalos];
            //Hay que calcular la probabilidad esperada.
            float prob_esperada;
            float int_de_clase;
            float limInf = min_valor;
            float limSup = min_valor + ancho_int;
            for (int i = 0; i < frec_esp_exp.Length; i++)
            {
                int_de_clase = (limSup + limInf) / 2;
                prob_esperada = lambda * (float)Math.Exp(-lambda * int_de_clase) * (limSup - limInf);

                frec_esp_exp[i] = prob_esperada * cantidadNum;

                limInf = limSup;
                limSup = limSup + ancho_int;
            }

            return frec_esp_exp;            
        }
        private int gradosLibertadPoisson(int intervalos, int cantDatosEmpiricos)
        {
            grLibertad_poisson = intervalos - 1 - cantDatosEmpiricos;
            return grLibertad_poisson;
        }
        private double calcularErrorRelativoPoisson(int[] lista_frecuencias)
        {
            double frec_esp = frec_esp_exp[0];
            int frec_obt = lista_frecuencias[0];
            double aux1;
            double aux2;

            for (int i = 0; i < lista_frecuencias.Length; i++)
            {
                if (frec_esp >= 5 && i != lista_frecuencias.Length)//Si es mayor a 5 entra y prepara el siguiente.
                {
                    aux1 = frec_obt - frec_esp;
                    aux2 = Math.Pow(aux1, 2);
                    error_rel_poisson += aux2 / frec_esp;

                    frec_esp = frec_esp_exp[i + 1];
                    frec_obt = lista_frecuencias[i + 1];
                }
                else if (frec_esp < 5 && i != lista_frecuencias.Length)//Si es menor a 5 le suma el siguiente.
                {
                    frec_esp = frec_esp_exp[i] + frec_esp_exp[i + 1];
                    frec_obt = lista_frecuencias[i] + lista_frecuencias[i + 1];
                }
                else if (frec_esp < 5 && i == lista_frecuencias.Length)//Si es menor a 5 y es el ultimo intervalo se lo sumamos al anterior.
                {
                    frec_esp = frec_esp_exp[i - 1] + frec_esp_exp[i];
                    frec_obt = lista_frecuencias[i - 1] + lista_frecuencias[i];
                }
                else if (frec_esp >= 5 && i == lista_frecuencias.Length)//Si es mayor a 5 y es el ultimo intervalo, no prepara al siguiente.
                {
                    aux1 = frec_obt - frec_esp;
                    aux2 = Math.Pow(aux1, 2);
                    error_rel_poisson += aux2 / frec_esp;
                }
            }
            return error_rel_poisson;
        }
        public String calcularHipotesisPoisson(int intervalos, int cantidadNum, float lambda, int cantDatosEmp, int[] lista_frecuencias, float minimo_valor, float ancho_intervalo)
        {
            //Chi hasta 30 grados de libertad
            calculoFrecEsperadaExponencial(intervalos, cantidadNum, lambda, minimo_valor, ancho_intervalo);
            calcularErrorRelativoExponencial(lista_frecuencias);
            gradosLibertadExponencial(intervalos, cantDatosEmp);
            string str = "No Aceptamos";
            double errTab;
            errTab = chi_095[grLibertad_exp];

            if (error_rel_exp < errTab)
            {
                str = "Aceptamos";
            }

            return str;
        }
        */

        //--------------------------------------------------------------------------------------------------------------------------------------
        //Normal
        double[] lista_frec_esp_normal;
        double error_rel_normal;
        int[] lista_frecuenciasNormal;
        int grLibertad_normal;

        private int[] armarListaFrecuenciasNormal(double[] lista, int cantidadNum, int intervalos)
        {
            //int posicion;
            //double ancho_intervalo = 1.0 / intervalos;
            int ancho_intervalo = 1;
            int lim_inf = 0;
            int lim_sup = 0;

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


        private double[] calculoFrecEsperadaNormal(int intervalos, float media, float desv_estandar, int cant_Numeros)
        {
            lista_frec_esp_normal = new double[intervalos];
            int ancho_intervalo = 1;
            int lim_inf = 0;
            int lim_sup = 0;
                        
            double aux1 = - 1 / 2.0;
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
                    var_frec_esp_normal += double.Parse(Lista_Frec_Obtenida_Normal[index - 1].ToString());
                    var_frec_obt_normal += int.Parse(Lista_Frec_Obtenida_Normal[index - 1].ToString());

                    Lista_Frec_Esperada_Normal.Insert(index-1, var_frec_esp_normal);
                    Lista_Frec_Obtenida_Normal.Insert(index-1, var_frec_obt_normal);                    
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
        public String calcularHipotesisNormal(double[] listaNumeros, int intervalos, int cantidadNum, float media, float desv_estandar)
        {
            //Chi hasta 30 grados de libertad            
            armarListaFrecuenciasNormal(listaNumeros, cantidadNum, intervalos);
            calculoFrecEsperadaNormal(intervalos, media, desv_estandar, cantidadNum);
            calcularErrorRelativoNormal(lista_frecuenciasNormal);
            gradosLibertadNormal(intervalos, 2);
            string str = "No Aceptamos";
            double errTab;
            errTab = chi_095[grLibertad_normal];

            if (error_rel_normal < errTab)
            {
                str = "Aceptamos";
            }

            return str;
        }

    }
}
