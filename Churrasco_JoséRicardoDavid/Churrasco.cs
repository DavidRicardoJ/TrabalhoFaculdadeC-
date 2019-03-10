using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Churrasco
    {
        private double precoCarne, quantCarne;
        private double precoLinguica, quantLinguica;
        private double precoPao, quantPao;

        private double precoCerveja, quantCerveja;
        private double precoRefri, quantRefri;
        private double precoCarvao, quantCarvao;

        private double nPessoas;

        public Churrasco(double precoCarne, double quantCarne, double precoLinguica, double quantLinguica, double precoPao, double quantPao, double precoCerveja, double quantCerveja, double precoRefri, double quantRefri, double precoCarvao, double quantCarvao, double nPessoas)
        {
            this.precoCarne = precoCarne;
            this.quantCarne = quantCarne;
            this.precoLinguica = precoLinguica;
            this.quantLinguica = quantLinguica;
            this.precoPao = precoPao;
            this.quantPao = quantPao;
            this.precoCerveja = precoCerveja;
            this.quantCerveja = quantCerveja;
            this.precoRefri = precoRefri;
            this.quantRefri = quantRefri;
            this.precoCarvao = precoCarvao;
            this.quantCarvao = quantCarvao;
            this.nPessoas = nPessoas;
        }

        public double NPessoas { get => nPessoas; set => nPessoas = value; }

        public double valorTotal ()
        {
            double total = precoCarne * quantCarne + precoLinguica * quantLinguica + precoPao * quantPao + precoCerveja * quantCerveja +
                precoRefri * quantRefri + precoCarvao * quantCarvao;
            return total;
        }
        
    }
}
