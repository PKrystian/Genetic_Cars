using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopulationController : MonoBehaviour
{
    List<GeneticPathfinder> population = new List<GeneticPathfinder>();
    public GameObject creaturePrefab;
    public int populationSize = 100;
    public int genomeLength;
    public float cutoff = 0.3f;
    public int survivorKeep = 5;
    [Range(0f, 1f)]
    public float mutationRate = 0.01f;
    public Transform spawnPoint;
    public Transform end;
	public int j=1;
    public float maxFitness;

    void InitPopulation()
    {
        for(int i = 0; i < populationSize; i++)
        {
            GameObject go = Instantiate(creaturePrefab, spawnPoint.position, Quaternion.identity);
            go.GetComponent<GeneticPathfinder>().InitCreature(new DNA(genomeLength), end.position);
            population.Add(go.GetComponent<GeneticPathfinder>());
        }
    }
    void NextGeneration()
    {
        int survivorCut = Mathf.RoundToInt(populationSize * cutoff);
        List<GeneticPathfinder> survivors = new List<GeneticPathfinder>();
        for(int i = 0; i < survivorCut; i++)
        {
            survivors.Add(GetFittest());
        }
        for(int i =0; i<population.Count; i++)
        {
            Destroy(population[i].gameObject);
        }
        population.Clear();
        for(int i=0; i<survivorKeep;i++)
        {
            GameObject go = Instantiate(creaturePrefab, spawnPoint.position, Quaternion.identity);
            go.GetComponent<GeneticPathfinder>().InitCreature(survivors[i].dna, end.position);
            population.Add(go.GetComponent<GeneticPathfinder>());
        }
        while(population.Count < populationSize)
        {
            for(int i=0; i< survivors.Count; i++)
            {
                GameObject go = Instantiate(creaturePrefab, spawnPoint.position, Quaternion.identity);
                go.GetComponent<GeneticPathfinder>().InitCreature(new DNA(survivors[i].dna, survivors[Random.Range(0, 10)].dna, mutationRate), end.position);
                population.Add(go.GetComponent<GeneticPathfinder>());
                if(population.Count >= populationSize)
                {
                    break;
                }
            }
        }
        for(int i=0;i < survivors.Count; i++)
        {
            Destroy(survivors[i].gameObject);
        }
    }
    private void Start()
    {
        InitPopulation();
    }
    private void Update()
    {
        if (!HasActive())
        {
            NextGeneration();

            Debug.Log("Generation: " + j);
            j++;
            Debug.Log("Fittest: " + maxFitness);
        }
    }
    GeneticPathfinder GetFittest()
    {
        maxFitness = float.MinValue;
        int index = 0;
        for(int i = 0; i < population.Count; i++)
        {
            if (population[i].fitness > maxFitness)
            {
                maxFitness = population[i].fitness;
                index = i;
            }
        }
        GeneticPathfinder fittest = population[index];
        population.Remove(fittest);
        return fittest;
    }
    bool HasActive()
    {
        for(int i = 0; i < population.Count; i++)
        {
            if (!population[i].hasFinished)
            {
                return true;
            }
        }
        return false;
    }
}