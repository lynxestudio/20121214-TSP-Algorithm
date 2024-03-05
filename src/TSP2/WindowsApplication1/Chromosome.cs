using System;

namespace TSP{

public class Chromosome {

  
  protected int [] cityList;

  
  protected double cost;

 
  protected double mutationPercent;

 
  protected int cutLength;

  Random random = new Random();

 
  public Chromosome(SupplyPoint[] cities) {
    bool[] taken = new bool[cities.Length];
    cityList = new int[cities.Length];
    cost = 0.0;
    for ( int i=0;i<cityList.Length;i++ ) taken[i] = false;
    for ( int i=0;i<cityList.Length-1;i++ ) {
      int icandidate;
      do {
        icandidate = (int) ( 0.999999* random.NextDouble() * 
                             (double) cityList.Length );
      } while ( taken[icandidate] );
      cityList[i] = icandidate;
      taken[icandidate] = true;
      if ( i == cityList.Length-2 ) {
        icandidate = 0;
        while ( taken[icandidate] ) icandidate++;
        cityList[i+1] = icandidate;
      }
    }
    calculateCost(cities);
    cutLength = 1;
  }

  public void calculateCost(SupplyPoint [] cities) {
    cost=0;
    for ( int i=0;i<cityList.Length-1;i++ ) {
      double dist = cities[cityList[i]].proximity(cities[cityList[i+1]]);
      cost += dist;
    }
  }



  public double getCost() {
    return cost;
  }


  public int getCity(int i) {
    return cityList[i];
  }

  
  void setCities(int [] list) {
    for ( int i=0;i<cityList.Length;i++ ) {
      cityList[i] = list[i];
    }
  }

  
  void setCity(int index, int value) {
    cityList[index] = value;
  }

  
  public void setCut(int cut) {
    cutLength = cut;
  }

  
  public void setMutation(double prob) {
    mutationPercent = prob;
  }
  


  public int mate(Chromosome father, Chromosome offspring1, Chromosome offspring2) {
      int cutpoint1 = (int)(0.999999 * random.NextDouble() * (double)(cityList.Length - cutLength));
    int cutpoint2 = cutpoint1 + cutLength;

    bool[] taken1  = new bool[cityList.Length];
    bool[] taken2  = new bool[cityList.Length];
    int[] off1  = new int[cityList.Length];
    int[] off2  = new int[cityList.Length];

    for ( int i=0;i<cityList.Length;i++ ) {
      taken1[i] = false;
      taken2[i] = false;
    }

    for ( int i=0;i<cityList.Length;i++ ) {
      if ( i<cutpoint1 || i>= cutpoint2 ) {
        off1[i] = -1;
        off2[i] = -1;
      } else {
        int imother = cityList[i];
        int ifather = father.getCity(i);
        off1[i] = ifather;
        off2[i] = imother;
        taken1[ifather] = true;
        taken2[imother] = true;
      }
    }

    for ( int i=0;i<cutpoint1;i++ ) {
      if ( off1[i] == -1 ) {
        for ( int j=0;j<cityList.Length;j++ ) {
          int imother = cityList[j];
          if ( !taken1[imother] ) {
            off1[i] = imother;
            taken1[imother] = true;
            break;
          }
        }
      }
      if ( off2[i] == -1 ) {
        for ( int j=0;j<cityList.Length;j++ ) {
          int ifather = father.getCity(j);
          if ( !taken2[ifather] ) {
            off2[i] = ifather;
            taken2[ifather] = true;
            break;
          }
        }
      }
    }
    for ( int i=cityList.Length-1;i>=cutpoint2;i-- ) {
      if ( off1[i] == -1 ) {
        for ( int j=cityList.Length-1;j>=0;j-- ) {
          int imother = cityList[j];
          if ( !taken1[imother] ) {
            off1[i] = imother;
            taken1[imother] = true;
            break;
          }
        }
      }
      if ( off2[i] == -1 ) {
        for ( int j=cityList.Length-1;j>=0;j-- ) {
          int ifather = father.getCity(j);
          if ( !taken2[ifather] ) {
            off2[i] = ifather;
            taken2[ifather] = true;
            break;
          }
        }
      }
    }

    offspring1.setCities(off1);
    offspring2.setCities(off2);

    int mutate = 0;
    if (random.NextDouble() < mutationPercent)
    {
        int iswap1 = (int)(0.999999 * random.NextDouble() * (double)(cityList.Length));
        int iswap2 = (int)(0.999999 * random.NextDouble() * (double)cityList.Length);
      int i = off1[iswap1];
      off1[iswap1] = off1[iswap2];
      off1[iswap2] = i;
      mutate++;
    }
    if (random.NextDouble() < mutationPercent)
    {
        int iswap1 = (int)(0.999999 * random.NextDouble() * (double)(cityList.Length));
        int iswap2 = (int)(0.999999 * random.NextDouble() * (double)cityList.Length);
      int i = off2[iswap1];
      off2[iswap1] = off2[iswap2];
      off2[iswap2] = i;
      mutate++;
    }
    return mutate;
  }


  public static void sortChromosomes(Chromosome[] chromosomes, int num)
  {
    Chromosome ctemp;
    bool swapped = true;
    while ( swapped ) {
      swapped = false;
      for ( int i=0;i<num-1;i++ ) {
        if ( chromosomes[i].getCost() > chromosomes[i+1].getCost() ) {
          ctemp = chromosomes[i];
          chromosomes[i] = chromosomes[i+1];
          chromosomes[i+1] = ctemp;
          swapped = true;
        }
      }
    }
  }

}
}