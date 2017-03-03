using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MachineLearning
{
    public class Dna
    {
        Vector[] genes;
        int lifespan;

        public Dna(int lifesp)
        {
            lifespan = lifesp;
            genes = new Vector[lifespan];
            for (int i = 0; i < lifespan; i++)
            {
                genes[i] = new RndVector2D().vec;
            }
        }

        public Vector getCurrentGene(int count)
        {
            return genes[count];
        }

        public Dna CrossOver(Dna partner)
        {
            Dna newDna = new Dna(lifespan);
            int mid = RandomGen.rnd.Next(1, genes.Length);

            for (int i = 0; i < genes.Length; i++)
            {
                if (i < mid)
                {
                    newDna.genes[i] = genes[i];
                }
                else
                {
                    newDna.genes[i] = partner.genes[i];
                }
            }

            Mutate(ref newDna);

            return newDna;
        }

        private void Mutate(ref Dna genesMutate)
        {
            for (int i = 0; i < genesMutate.genes.Length; i++)
            {
                int n = RandomGen.rnd.Next(0, 1000);
                if (n < 5)
                {
                    genesMutate.genes[i] = new RndVector2D().vec;
                }
            }
        }



    }
}
