using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScript : MonoBehaviour
{
    //RUNTIME
    private int globalCounter = 0;
    private int counter = 0;
    private int trash = 0;
    private int[][] v4D = new int[1624][];
    private int[][] v5D = new int[7152][];
    private int[][] v6D = new int[26016][];
    private int[][] v7D = new int[72912][];
    private int[][] v8D = new int[140704][];
    private int[][] v9D = new int[140704][];
    private int rand = 0;
    [SerializeField] private GameObject posCombText;
    [SerializeField] private GameObject codeText;
    [SerializeField] private GameObject circlesPanel;
    private LineRenderer line;

    //FUNCTIONS
    void Start()
    {
        line = GetComponent<LineRenderer>();

        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                for (int k = 1; k <= 9; k++)
                {
                    for (int l = 1; l <= 9; l++)
                    {

                        if (i != j && i != k && i != l && j != k && j != l && k != l)
                        {

                            if ((i == 1 && j == 3) || (i == 4 && j == 6) || (i == 7 && j == 9))
                            {
                                trash++;
                            }
                            else if ((i == 3 && j == 1) || (i == 6 && j == 4) || (i == 9 && j == 7))
                            {
                                trash++;
                            }
                            else if ((i == 1 && j == 7) || (i == 2 && j == 8) || (i == 3 && j == 9))
                            {
                                trash++;
                            }
                            else if ((i == 7 && j == 1) || (i == 8 && j == 2) || (i == 9 && j == 3))
                            {
                                trash++;
                            }
                            else if ((i == 1 && j == 9) || (i == 3 && j == 7) || (i == 9 && j == 1) || (i == 7 && j == 3))
                            {
                                trash++;
                            }
                            else if (j == 1 && k == 3 && i != 2)
                            {
                                trash++;
                            }
                            else if (j == 3 && k == 1 && i != 2)
                            {
                                trash++;
                            }
                            else if (j == 4 && k == 6 && i != 5)
                            {
                                trash++;
                            }
                            else if (j == 6 && k == 4 && i != 5)
                            {
                                trash++;
                            }
                            else if (j == 7 && k == 9 && i != 8)
                            {
                                trash++;
                            }
                            else if (j == 9 && k == 7 && i != 8)
                            {
                                trash++;
                            }
                            else if (j == 1 && k == 7 && i != 4)
                            {
                                trash++;
                            }
                            else if (j == 7 && k == 1 && i != 4)
                            {
                                trash++;
                            }
                            else if (j == 2 && k == 8 && i != 5)
                            {
                                trash++;
                            }
                            else if (j == 8 && k == 2 && i != 5)
                            {
                                trash++;
                            }
                            else if (j == 3 && k == 9 && i != 6)
                            {
                                trash++;
                            }
                            else if (j == 9 && k == 3 && i != 6)
                            {
                                trash++;
                            }
                            else if (j == 1 && k == 9 && i != 5)
                            {
                                trash++;
                            }
                            else if (j == 9 && k == 1 && i != 5)
                            {
                                trash++;
                            }
                            else if (j == 3 && k == 7 && i != 5)
                            {
                                trash++;
                            }
                            else if (j == 7 && k == 3 && i != 5)
                            {
                                trash++;
                            }
                            else if (k == 1 && l == 3 && (i != 2 && j != 2))
                            {
                                trash++;
                            }
                            else if (k == 3 && l == 1 && (i != 2 && j != 2))
                            {
                                trash++;
                            }
                            else if (k == 4 && l == 6 && (i != 5 && j != 5))
                            {
                                trash++;
                            }
                            else if (k == 6 && l == 4 && (i != 5 && j != 5))
                            {
                                trash++;
                            }
                            else if (k == 7 && l == 9 && (i != 8 && j != 8))
                            {
                                trash++;
                            }
                            else if (k == 9 && l == 7 && (i != 8 && j != 8))
                            {
                                trash++;
                            }
                            else if (k == 1 && l == 7 && (i != 4 && j != 4))
                            {
                                trash++;
                            }
                            else if (k == 7 && l == 1 && (i != 4 && j != 4))
                            {
                                trash++;
                            }
                            else if (k == 2 && l == 8 && (i != 5 && j != 5))
                            {
                                trash++;
                            }
                            else if (k == 8 && l == 2 && (i != 5 && j != 5))
                            {
                                trash++;
                            }
                            else if (k == 3 && l == 9 && (i != 6 && j != 6))
                            {
                                trash++;
                            }
                            else if (k == 9 && l == 3 && (i != 6 && j != 6))
                            {
                                trash++;
                            }
                            else if (k == 1 && l == 9 && (i != 5 && j != 5))
                            {
                                trash++;
                            }
                            else if (k == 9 && l == 1 && (i != 5 && j != 5))
                            {
                                trash++;
                            }
                            else if (k == 3 && l == 7 && (i != 5 && j != 5))
                            {
                                trash++;
                            }
                            else if (k == 7 && l == 3 && (i != 5 && j != 5))
                            {
                                trash++;
                            }
                            else
                            {
                                globalCounter++;
                                v4D[counter] = new int[9] {i,j,k,l,0,0,0,0,0};
                                counter++;
                            }
                        }
                        else
                        {
                            trash++;
                        }
                    }
                }
            }
        }
        counter = 0;
        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                for (int k = 1; k <= 9; k++)
                {
                    for (int l = 1; l <= 9; l++)
                    {
                        for (int f = 1; f <= 9; f++)
                        {

                            if (i != j && i != k && i != l && i != f && j != k && j != l && j != f && k != l && k != f && l != f)
                            {

                                if ((i == 1 && j == 3) || (i == 4 && j == 6) || (i == 7 && j == 9))
                                {
                                    trash++;
                                }
                                else if ((i == 3 && j == 1) || (i == 6 && j == 4) || (i == 9 && j == 7))
                                {
                                    trash++;
                                }
                                else if ((i == 1 && j == 7) || (i == 2 && j == 8) || (i == 3 && j == 9))
                                {
                                    trash++;
                                }
                                else if ((i == 7 && j == 1) || (i == 8 && j == 2) || (i == 9 && j == 3))
                                {
                                    trash++;
                                }
                                else if ((i == 1 && j == 9) || (i == 3 && j == 7) || (i == 9 && j == 1) || (i == 7 && j == 3))
                                {
                                    trash++;
                                }
                                else if (j == 1 && k == 3 && i != 2)
                                {
                                    trash++;
                                }
                                else if (j == 3 && k == 1 && i != 2)
                                {
                                    trash++;
                                }
                                else if (j == 4 && k == 6 && i != 5)
                                {
                                    trash++;
                                }
                                else if (j == 6 && k == 4 && i != 5)
                                {
                                    trash++;
                                }
                                else if (j == 7 && k == 9 && i != 8)
                                {
                                    trash++;
                                }
                                else if (j == 9 && k == 7 && i != 8)
                                {
                                    trash++;
                                }
                                else if (j == 1 && k == 7 && i != 4)
                                {
                                    trash++;
                                }
                                else if (j == 7 && k == 1 && i != 4)
                                {
                                    trash++;
                                }
                                else if (j == 2 && k == 8 && i != 5)
                                {
                                    trash++;
                                }
                                else if (j == 8 && k == 2 && i != 5)
                                {
                                    trash++;
                                }
                                else if (j == 3 && k == 9 && i != 6)
                                {
                                    trash++;
                                }
                                else if (j == 9 && k == 3 && i != 6)
                                {
                                    trash++;
                                }
                                else if (j == 1 && k == 9 && i != 5)
                                {
                                    trash++;
                                }
                                else if (j == 9 && k == 1 && i != 5)
                                {
                                    trash++;
                                }
                                else if (j == 3 && k == 7 && i != 5)
                                {
                                    trash++;
                                }
                                else if (j == 7 && k == 3 && i != 5)
                                {
                                    trash++;
                                }
                                else if (k == 1 && l == 3 && (i != 2 && j != 2))
                                {
                                    trash++;
                                }
                                else if (k == 3 && l == 1 && (i != 2 && j != 2))
                                {
                                    trash++;
                                }
                                else if (k == 4 && l == 6 && (i != 5 && j != 5))
                                {
                                    trash++;
                                }
                                else if (k == 6 && l == 4 && (i != 5 && j != 5))
                                {
                                    trash++;
                                }
                                else if (k == 7 && l == 9 && (i != 8 && j != 8))
                                {
                                    trash++;
                                }
                                else if (k == 9 && l == 7 && (i != 8 && j != 8))
                                {
                                    trash++;
                                }
                                else if (k == 1 && l == 7 && (i != 4 && j != 4))
                                {
                                    trash++;
                                }
                                else if (k == 7 && l == 1 && (i != 4 && j != 4))
                                {
                                    trash++;
                                }
                                else if (k == 2 && l == 8 && (i != 5 && j != 5))
                                {
                                    trash++;
                                }
                                else if (k == 8 && l == 2 && (i != 5 && j != 5))
                                {
                                    trash++;
                                }
                                else if (k == 3 && l == 9 && (i != 6 && j != 6))
                                {
                                    trash++;
                                }
                                else if (k == 9 && l == 3 && (i != 6 && j != 6))
                                {
                                    trash++;
                                }
                                else if (k == 1 && l == 9 && (i != 5 && j != 5))
                                {
                                    trash++;
                                }
                                else if (k == 9 && l == 1 && (i != 5 && j != 5))
                                {
                                    trash++;
                                }
                                else if (k == 3 && l == 7 && (i != 5 && j != 5))
                                {
                                    trash++;
                                }
                                else if (k == 7 && l == 3 && (i != 5 && j != 5))
                                {
                                    trash++;
                                }
                                else if (l == 1 && f == 3 && (i != 2 && j != 2 && k != 2))
                                {
                                    trash++;
                                }
                                else if (l == 3 && f == 1 && (i != 2 && j != 2 && k != 2))
                                {
                                    trash++;
                                }
                                else if (l == 4 && f == 6 && (i != 5 && j != 5 && k != 5))
                                {
                                    trash++;
                                }
                                else if (l == 6 && f == 4 && (i != 5 && j != 5 && k != 5))
                                {
                                    trash++;
                                }
                                else if (l == 7 && f == 9 && (i != 8 && j != 8 && k != 8))
                                {
                                    trash++;
                                }
                                else if (l == 9 && f == 7 && (i != 8 && j != 8 && k != 8))
                                {
                                    trash++;
                                }
                                else if (l == 1 && f == 7 && (i != 4 && j != 4 && k != 4))
                                {
                                    trash++;
                                }
                                else if (l == 7 && f == 1 && (i != 4 && j != 4 && k != 4))
                                {
                                    trash++;
                                }
                                else if (l == 2 && f == 8 && (i != 5 && j != 5 && k != 5))
                                {
                                    trash++;
                                }
                                else if (l == 8 && f == 2 && (i != 5 && j != 5 && k != 5))
                                {
                                    trash++;
                                }
                                else if (l == 3 && f == 9 && (i != 6 && j != 6 && k != 6))
                                {
                                    trash++;
                                }
                                else if (l == 9 && f == 3 && (i != 6 && j != 6 && k != 6))
                                {
                                    trash++;
                                }
                                else if (l == 1 && f == 9 && (i != 5 && j != 5 && k != 5))
                                {
                                    trash++;
                                }
                                else if (l == 9 && f == 1 && (i != 5 && j != 5 && k != 5))
                                {
                                    trash++;
                                }
                                else if (l == 3 && f == 7 && (i != 5 && j != 5 && k != 5))
                                {
                                    trash++;
                                }
                                else if (l == 7 && f == 3 && (i != 5 && j != 5 && k != 5))
                                {
                                    trash++;
                                }
                                else
                                {
                                    globalCounter++;
                                    v5D[counter] = new int[9] {i,j,k,l,f,0,0,0,0};
                                    counter++;
                                }
                            }
                            else
                            {
                                trash++;
                            }
                        }
                    }
                }
            }
        }
        counter = 0;
        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                for (int k = 1; k <= 9; k++)
                {
                    for (int l = 1; l <= 9; l++)
                    {
                        for (int f = 1; f <= 9; f++)
                        {
                            for (int t = 1; t <= 9; t++)
                            {

                                if (i != j && i != k && i != l && i != f && i != t && j != k && j != l && j != f && j != t
                                        && k != l && k != f && k != t && l != f && l != t && f != t)
                                {

                                    if ((i == 1 && j == 3) || (i == 4 && j == 6) || (i == 7 && j == 9))
                                    {
                                        trash++;
                                    }
                                    else if ((i == 3 && j == 1) || (i == 6 && j == 4) || (i == 9 && j == 7))
                                    {
                                        trash++;
                                    }
                                    else if ((i == 1 && j == 7) || (i == 2 && j == 8) || (i == 3 && j == 9))
                                    {
                                        trash++;
                                    }
                                    else if ((i == 7 && j == 1) || (i == 8 && j == 2) || (i == 9 && j == 3))
                                    {
                                        trash++;
                                    }
                                    else if ((i == 1 && j == 9) || (i == 3 && j == 7) || (i == 9 && j == 1) || (i == 7 && j == 3))
                                    {
                                        trash++;
                                    }
                                    else if (j == 1 && k == 3 && i != 2)
                                    {
                                        trash++;
                                    }
                                    else if (j == 3 && k == 1 && i != 2)
                                    {
                                        trash++;
                                    }
                                    else if (j == 4 && k == 6 && i != 5)
                                    {
                                        trash++;
                                    }
                                    else if (j == 6 && k == 4 && i != 5)
                                    {
                                        trash++;
                                    }
                                    else if (j == 7 && k == 9 && i != 8)
                                    {
                                        trash++;
                                    }
                                    else if (j == 9 && k == 7 && i != 8)
                                    {
                                        trash++;
                                    }
                                    else if (j == 1 && k == 7 && i != 4)
                                    {
                                        trash++;
                                    }
                                    else if (j == 7 && k == 1 && i != 4)
                                    {
                                        trash++;
                                    }
                                    else if (j == 2 && k == 8 && i != 5)
                                    {
                                        trash++;
                                    }
                                    else if (j == 8 && k == 2 && i != 5)
                                    {
                                        trash++;
                                    }
                                    else if (j == 3 && k == 9 && i != 6)
                                    {
                                        trash++;
                                    }
                                    else if (j == 9 && k == 3 && i != 6)
                                    {
                                        trash++;
                                    }
                                    else if (j == 1 && k == 9 && i != 5)
                                    {
                                        trash++;
                                    }
                                    else if (j == 9 && k == 1 && i != 5)
                                    {
                                        trash++;
                                    }
                                    else if (j == 3 && k == 7 && i != 5)
                                    {
                                        trash++;
                                    }
                                    else if (j == 7 && k == 3 && i != 5)
                                    {
                                        trash++;
                                    }
                                    else if (k == 1 && l == 3 && (i != 2 && j != 2))
                                    {
                                        trash++;
                                    }
                                    else if (k == 3 && l == 1 && (i != 2 && j != 2))
                                    {
                                        trash++;
                                    }
                                    else if (k == 4 && l == 6 && (i != 5 && j != 5))
                                    {
                                        trash++;
                                    }
                                    else if (k == 6 && l == 4 && (i != 5 && j != 5))
                                    {
                                        trash++;
                                    }
                                    else if (k == 7 && l == 9 && (i != 8 && j != 8))
                                    {
                                        trash++;
                                    }
                                    else if (k == 9 && l == 7 && (i != 8 && j != 8))
                                    {
                                        trash++;
                                    }
                                    else if (k == 1 && l == 7 && (i != 4 && j != 4))
                                    {
                                        trash++;
                                    }
                                    else if (k == 7 && l == 1 && (i != 4 && j != 4))
                                    {
                                        trash++;
                                    }
                                    else if (k == 2 && l == 8 && (i != 5 && j != 5))
                                    {
                                        trash++;
                                    }
                                    else if (k == 8 && l == 2 && (i != 5 && j != 5))
                                    {
                                        trash++;
                                    }
                                    else if (k == 3 && l == 9 && (i != 6 && j != 6))
                                    {
                                        trash++;
                                    }
                                    else if (k == 9 && l == 3 && (i != 6 && j != 6))
                                    {
                                        trash++;
                                    }
                                    else if (k == 1 && l == 9 && (i != 5 && j != 5))
                                    {
                                        trash++;
                                    }
                                    else if (k == 9 && l == 1 && (i != 5 && j != 5))
                                    {
                                        trash++;
                                    }
                                    else if (k == 3 && l == 7 && (i != 5 && j != 5))
                                    {
                                        trash++;
                                    }
                                    else if (k == 7 && l == 3 && (i != 5 && j != 5))
                                    {
                                        trash++;
                                    }
                                    else if (l == 1 && f == 3 && (i != 2 && j != 2 && k != 2))
                                    {
                                        trash++;
                                    }
                                    else if (l == 3 && f == 1 && (i != 2 && j != 2 && k != 2))
                                    {
                                        trash++;
                                    }
                                    else if (l == 4 && f == 6 && (i != 5 && j != 5 && k != 5))
                                    {
                                        trash++;
                                    }
                                    else if (l == 6 && f == 4 && (i != 5 && j != 5 && k != 5))
                                    {
                                        trash++;
                                    }
                                    else if (l == 7 && f == 9 && (i != 8 && j != 8 && k != 8))
                                    {
                                        trash++;
                                    }
                                    else if (l == 9 && f == 7 && (i != 8 && j != 8 && k != 8))
                                    {
                                        trash++;
                                    }
                                    else if (l == 1 && f == 7 && (i != 4 && j != 4 && k != 4))
                                    {
                                        trash++;
                                    }
                                    else if (l == 7 && f == 1 && (i != 4 && j != 4 && k != 4))
                                    {
                                        trash++;
                                    }
                                    else if (l == 2 && f == 8 && (i != 5 && j != 5 && k != 5))
                                    {
                                        trash++;
                                    }
                                    else if (l == 8 && f == 2 && (i != 5 && j != 5 && k != 5))
                                    {
                                        trash++;
                                    }
                                    else if (l == 3 && f == 9 && (i != 6 && j != 6 && k != 6))
                                    {
                                        trash++;
                                    }
                                    else if (l == 9 && f == 3 && (i != 6 && j != 6 && k != 6))
                                    {
                                        trash++;
                                    }
                                    else if (l == 1 && f == 9 && (i != 5 && j != 5 && k != 5))
                                    {
                                        trash++;
                                    }
                                    else if (l == 9 && f == 1 && (i != 5 && j != 5 && k != 5))
                                    {
                                        trash++;
                                    }
                                    else if (l == 3 && f == 7 && (i != 5 && j != 5 && k != 5))
                                    {
                                        trash++;
                                    }
                                    else if (l == 7 && f == 3 && (i != 5 && j != 5 && k != 5))
                                    {
                                        trash++;
                                    }
                                    else if (f == 1 && t == 3 && (i != 2 && j != 2 && k != 2 && l != 2))
                                    {
                                        trash++;
                                    }
                                    else if (f == 3 && t == 1 && (i != 2 && j != 2 && k != 2 && l != 2))
                                    {
                                        trash++;
                                    }
                                    else if (f == 4 && t == 6 && (i != 5 && j != 5 && k != 5 && l != 5))
                                    {
                                        trash++;
                                    }
                                    else if (f == 6 && t == 4 && (i != 5 && j != 5 && k != 5 && l != 5))
                                    {
                                        trash++;
                                    }
                                    else if (f == 7 && t == 9 && (i != 8 && j != 8 && k != 8 && l != 8))
                                    {
                                        trash++;
                                    }
                                    else if (f == 9 && t == 7 && (i != 8 && j != 8 && k != 8 && l != 8))
                                    {
                                        trash++;
                                    }
                                    else if (f == 1 && t == 7 && (i != 4 && j != 4 && k != 4 && l != 4))
                                    {
                                        trash++;
                                    }
                                    else if (f == 7 && t == 1 && (i != 4 && j != 4 && k != 4 && l != 4))
                                    {
                                        trash++;
                                    }
                                    else if (f == 2 && t == 8 && (i != 5 && j != 5 && k != 5 && l != 5))
                                    {
                                        trash++;
                                    }
                                    else if (f == 8 && t == 2 && (i != 5 && j != 5 && k != 5 && l != 5))
                                    {
                                        trash++;
                                    }
                                    else if (f == 3 && t == 9 && (i != 6 && j != 6 && k != 6 && l != 6))
                                    {
                                        trash++;
                                    }
                                    else if (f == 9 && t == 3 && (i != 6 && j != 6 && k != 6 && l != 6))
                                    {
                                        trash++;
                                    }
                                    else if (f == 1 && t == 9 && (i != 5 && j != 5 && k != 5 && l != 5))
                                    {
                                        trash++;
                                    }
                                    else if (f == 9 && t == 1 && (i != 5 && j != 5 && k != 5 && l != 5))
                                    {
                                        trash++;
                                    }
                                    else if (f == 3 && t == 7 && (i != 5 && j != 5 && k != 5 && l != 5))
                                    {
                                        trash++;
                                    }
                                    else if (f == 7 && t == 3 && (i != 5 && j != 5 && k != 5 && l != 5))
                                    {
                                        trash++;
                                    }
                                    else
                                    {
                                        globalCounter++;
                                        v6D[counter] = new int[9] {i,j,k,l,f,t,0,0,0};
                                        counter++;
                                    }
                                }
                                else
                                {
                                    trash++;
                                }
                            }
                        }
                    }
                }
            }
        }
        counter = 0;
        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                for (int k = 1; k <= 9; k++)
                {
                    for (int l = 1; l <= 9; l++)
                    {
                        for (int f = 1; f <= 9; f++)
                        {
                            for (int t = 1; t <= 9; t++)
                            {
                                for (int h = 1; h <= 9; h++)
                                {

                                    if (i != j && i != k && i != l && i != f && i != t && i != h
                                            && j != k && j != l && j != f && j != t && j != h
                                            && k != l && k != f && k != t && k != h
                                            && l != f && l != t && l != h
                                            && f != t && f != h
                                            && t != h)
                                    {

                                        if ((i == 1 && j == 3) || (i == 4 && j == 6) || (i == 7 && j == 9))
                                        {
                                            trash++;
                                        }
                                        else if ((i == 3 && j == 1) || (i == 6 && j == 4) || (i == 9 && j == 7))
                                        {
                                            trash++;
                                        }
                                        else if ((i == 1 && j == 7) || (i == 2 && j == 8) || (i == 3 && j == 9))
                                        {
                                            trash++;
                                        }
                                        else if ((i == 7 && j == 1) || (i == 8 && j == 2) || (i == 9 && j == 3))
                                        {
                                            trash++;
                                        }
                                        else if ((i == 1 && j == 9) || (i == 3 && j == 7) || (i == 9 && j == 1) || (i == 7 && j == 3))
                                        {
                                            trash++;
                                        }
                                        else if (j == 1 && k == 3 && i != 2)
                                        {
                                            trash++;
                                        }
                                        else if (j == 3 && k == 1 && i != 2)
                                        {
                                            trash++;
                                        }
                                        else if (j == 4 && k == 6 && i != 5)
                                        {
                                            trash++;
                                        }
                                        else if (j == 6 && k == 4 && i != 5)
                                        {
                                            trash++;
                                        }
                                        else if (j == 7 && k == 9 && i != 8)
                                        {
                                            trash++;
                                        }
                                        else if (j == 9 && k == 7 && i != 8)
                                        {
                                            trash++;
                                        }
                                        else if (j == 1 && k == 7 && i != 4)
                                        {
                                            trash++;
                                        }
                                        else if (j == 7 && k == 1 && i != 4)
                                        {
                                            trash++;
                                        }
                                        else if (j == 2 && k == 8 && i != 5)
                                        {
                                            trash++;
                                        }
                                        else if (j == 8 && k == 2 && i != 5)
                                        {
                                            trash++;
                                        }
                                        else if (j == 3 && k == 9 && i != 6)
                                        {
                                            trash++;
                                        }
                                        else if (j == 9 && k == 3 && i != 6)
                                        {
                                            trash++;
                                        }
                                        else if (j == 1 && k == 9 && i != 5)
                                        {
                                            trash++;
                                        }
                                        else if (j == 9 && k == 1 && i != 5)
                                        {
                                            trash++;
                                        }
                                        else if (j == 3 && k == 7 && i != 5)
                                        {
                                            trash++;
                                        }
                                        else if (j == 7 && k == 3 && i != 5)
                                        {
                                            trash++;
                                        }
                                        else if (k == 1 && l == 3 && (i != 2 && j != 2))
                                        {
                                            trash++;
                                        }
                                        else if (k == 3 && l == 1 && (i != 2 && j != 2))
                                        {
                                            trash++;
                                        }
                                        else if (k == 4 && l == 6 && (i != 5 && j != 5))
                                        {
                                            trash++;
                                        }
                                        else if (k == 6 && l == 4 && (i != 5 && j != 5))
                                        {
                                            trash++;
                                        }
                                        else if (k == 7 && l == 9 && (i != 8 && j != 8))
                                        {
                                            trash++;
                                        }
                                        else if (k == 9 && l == 7 && (i != 8 && j != 8))
                                        {
                                            trash++;
                                        }
                                        else if (k == 1 && l == 7 && (i != 4 && j != 4))
                                        {
                                            trash++;
                                        }
                                        else if (k == 7 && l == 1 && (i != 4 && j != 4))
                                        {
                                            trash++;
                                        }
                                        else if (k == 2 && l == 8 && (i != 5 && j != 5))
                                        {
                                            trash++;
                                        }
                                        else if (k == 8 && l == 2 && (i != 5 && j != 5))
                                        {
                                            trash++;
                                        }
                                        else if (k == 3 && l == 9 && (i != 6 && j != 6))
                                        {
                                            trash++;
                                        }
                                        else if (k == 9 && l == 3 && (i != 6 && j != 6))
                                        {
                                            trash++;
                                        }
                                        else if (k == 1 && l == 9 && (i != 5 && j != 5))
                                        {
                                            trash++;
                                        }
                                        else if (k == 9 && l == 1 && (i != 5 && j != 5))
                                        {
                                            trash++;
                                        }
                                        else if (k == 3 && l == 7 && (i != 5 && j != 5))
                                        {
                                            trash++;
                                        }
                                        else if (k == 7 && l == 3 && (i != 5 && j != 5))
                                        {
                                            trash++;
                                        }
                                        else if (l == 1 && f == 3 && (i != 2 && j != 2 && k != 2))
                                        {
                                            trash++;
                                        }
                                        else if (l == 3 && f == 1 && (i != 2 && j != 2 && k != 2))
                                        {
                                            trash++;
                                        }
                                        else if (l == 4 && f == 6 && (i != 5 && j != 5 && k != 5))
                                        {
                                            trash++;
                                        }
                                        else if (l == 6 && f == 4 && (i != 5 && j != 5 && k != 5))
                                        {
                                            trash++;
                                        }
                                        else if (l == 7 && f == 9 && (i != 8 && j != 8 && k != 8))
                                        {
                                            trash++;
                                        }
                                        else if (l == 9 && f == 7 && (i != 8 && j != 8 && k != 8))
                                        {
                                            trash++;
                                        }
                                        else if (l == 1 && f == 7 && (i != 4 && j != 4 && k != 4))
                                        {
                                            trash++;
                                        }
                                        else if (l == 7 && f == 1 && (i != 4 && j != 4 && k != 4))
                                        {
                                            trash++;
                                        }
                                        else if (l == 2 && f == 8 && (i != 5 && j != 5 && k != 5))
                                        {
                                            trash++;
                                        }
                                        else if (l == 8 && f == 2 && (i != 5 && j != 5 && k != 5))
                                        {
                                            trash++;
                                        }
                                        else if (l == 3 && f == 9 && (i != 6 && j != 6 && k != 6))
                                        {
                                            trash++;
                                        }
                                        else if (l == 9 && f == 3 && (i != 6 && j != 6 && k != 6))
                                        {
                                            trash++;
                                        }
                                        else if (l == 1 && f == 9 && (i != 5 && j != 5 && k != 5))
                                        {
                                            trash++;
                                        }
                                        else if (l == 9 && f == 1 && (i != 5 && j != 5 && k != 5))
                                        {
                                            trash++;
                                        }
                                        else if (l == 3 && f == 7 && (i != 5 && j != 5 && k != 5))
                                        {
                                            trash++;
                                        }
                                        else if (l == 7 && f == 3 && (i != 5 && j != 5 && k != 5))
                                        {
                                            trash++;
                                        }
                                        else if (f == 1 && t == 3 && (i != 2 && j != 2 && k != 2 && l != 2))
                                        {
                                            trash++;
                                        }
                                        else if (f == 3 && t == 1 && (i != 2 && j != 2 && k != 2 && l != 2))
                                        {
                                            trash++;
                                        }
                                        else if (f == 4 && t == 6 && (i != 5 && j != 5 && k != 5 && l != 5))
                                        {
                                            trash++;
                                        }
                                        else if (f == 6 && t == 4 && (i != 5 && j != 5 && k != 5 && l != 5))
                                        {
                                            trash++;
                                        }
                                        else if (f == 7 && t == 9 && (i != 8 && j != 8 && k != 8 && l != 8))
                                        {
                                            trash++;
                                        }
                                        else if (f == 9 && t == 7 && (i != 8 && j != 8 && k != 8 && l != 8))
                                        {
                                            trash++;
                                        }
                                        else if (f == 1 && t == 7 && (i != 4 && j != 4 && k != 4 && l != 4))
                                        {
                                            trash++;
                                        }
                                        else if (f == 7 && t == 1 && (i != 4 && j != 4 && k != 4 && l != 4))
                                        {
                                            trash++;
                                        }
                                        else if (f == 2 && t == 8 && (i != 5 && j != 5 && k != 5 && l != 5))
                                        {
                                            trash++;
                                        }
                                        else if (f == 8 && t == 2 && (i != 5 && j != 5 && k != 5 && l != 5))
                                        {
                                            trash++;
                                        }
                                        else if (f == 3 && t == 9 && (i != 6 && j != 6 && k != 6 && l != 6))
                                        {
                                            trash++;
                                        }
                                        else if (f == 9 && t == 3 && (i != 6 && j != 6 && k != 6 && l != 6))
                                        {
                                            trash++;
                                        }
                                        else if (f == 1 && t == 9 && (i != 5 && j != 5 && k != 5 && l != 5))
                                        {
                                            trash++;
                                        }
                                        else if (f == 9 && t == 1 && (i != 5 && j != 5 && k != 5 && l != 5))
                                        {
                                            trash++;
                                        }
                                        else if (f == 3 && t == 7 && (i != 5 && j != 5 && k != 5 && l != 5))
                                        {
                                            trash++;
                                        }
                                        else if (f == 7 && t == 3 && (i != 5 && j != 5 && k != 5 && l != 5))
                                        {
                                            trash++;
                                        }
                                        else if (t == 1 && h == 3 && (i != 2 && j != 2 && k != 2 && l != 2 && f != 2))
                                        {
                                            trash++;
                                        }
                                        else if (t == 3 && h == 1 && (i != 2 && j != 2 && k != 2 && l != 2 && f != 2))
                                        {
                                            trash++;
                                        }
                                        else if (t == 4 && h == 6 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5))
                                        {
                                            trash++;
                                        }
                                        else if (t == 6 && h == 4 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5))
                                        {
                                            trash++;
                                        }
                                        else if (t == 7 && h == 9 && (i != 8 && j != 8 && k != 8 && l != 8 && f != 8))
                                        {
                                            trash++;
                                        }
                                        else if (t == 9 && h == 7 && (i != 8 && j != 8 && k != 8 && l != 8 && f != 8))
                                        {
                                            trash++;
                                        }
                                        else if (t == 1 && h == 7 && (i != 4 && j != 4 && k != 4 && l != 4 && f != 4))
                                        {
                                            trash++;
                                        }
                                        else if (t == 7 && h == 1 && (i != 4 && j != 4 && k != 4 && l != 4 && f != 4))
                                        {
                                            trash++;
                                        }
                                        else if (t == 2 && h == 8 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5))
                                        {
                                            trash++;
                                        }
                                        else if (t == 8 && h == 2 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5))
                                        {
                                            trash++;
                                        }
                                        else if (t == 3 && h == 9 && (i != 6 && j != 6 && k != 6 && l != 6 && f != 6))
                                        {
                                            trash++;
                                        }
                                        else if (t == 9 && h == 3 && (i != 6 && j != 6 && k != 6 && l != 6 && f != 6))
                                        {
                                            trash++;
                                        }
                                        else if (t == 1 && h == 9 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5))
                                        {
                                            trash++;
                                        }
                                        else if (t == 9 && h == 1 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5))
                                        {
                                            trash++;
                                        }
                                        else if (t == 3 && h == 7 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5))
                                        {
                                            trash++;
                                        }
                                        else if (t == 7 && h == 3 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5))
                                        {
                                            trash++;
                                        }
                                        else
                                        {  
                                            globalCounter++;
                                            v7D[counter] = new int[9] {i,j,k,l,f,t,h,0,0};
                                            counter++;
                                        }
                                    }
                                    else
                                    {
                                        trash++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        counter = 0;
        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                for (int k = 1; k <= 9; k++)
                {
                    for (int l = 1; l <= 9; l++)
                    {
                        for (int f = 1; f <= 9; f++)
                        {
                            for (int t = 1; t <= 9; t++)
                            {
                                for (int h = 1; h <= 9; h++)
                                {
                                    for (int g = 1; g <= 9; g++)
                                    {

                                        if (i != j && i != k && i != l && i != f && i != t && i != h && i != g
                                                && j != k && j != l && j != f && j != t && j != h && j != g
                                                && k != l && k != f && k != t && k != h && k != g
                                                && l != f && l != t && l != h && l != g
                                                && f != t && f != h && f != g
                                                && t != h && t != g
                                                && h != g)
                                        {

                                            if ((i == 1 && j == 3) || (i == 4 && j == 6) || (i == 7 && j == 9))
                                            {
                                                trash++;
                                            }
                                            else if ((i == 3 && j == 1) || (i == 6 && j == 4) || (i == 9 && j == 7))
                                            {
                                                trash++;
                                            }
                                            else if ((i == 1 && j == 7) || (i == 2 && j == 8) || (i == 3 && j == 9))
                                            {
                                                trash++;
                                            }
                                            else if ((i == 7 && j == 1) || (i == 8 && j == 2) || (i == 9 && j == 3))
                                            {
                                                trash++;
                                            }
                                            else if ((i == 1 && j == 9) || (i == 3 && j == 7) || (i == 9 && j == 1) || (i == 7 && j == 3))
                                            {
                                                trash++;
                                            }
                                            else if (j == 1 && k == 3 && i != 2)
                                            {
                                                trash++;
                                            }
                                            else if (j == 3 && k == 1 && i != 2)
                                            {
                                                trash++;
                                            }
                                            else if (j == 4 && k == 6 && i != 5)
                                            {
                                                trash++;
                                            }
                                            else if (j == 6 && k == 4 && i != 5)
                                            {
                                                trash++;
                                            }
                                            else if (j == 7 && k == 9 && i != 8)
                                            {
                                                trash++;
                                            }
                                            else if (j == 9 && k == 7 && i != 8)
                                            {
                                                trash++;
                                            }
                                            else if (j == 1 && k == 7 && i != 4)
                                            {
                                                trash++;
                                            }
                                            else if (j == 7 && k == 1 && i != 4)
                                            {
                                                trash++;
                                            }
                                            else if (j == 2 && k == 8 && i != 5)
                                            {
                                                trash++;
                                            }
                                            else if (j == 8 && k == 2 && i != 5)
                                            {
                                                trash++;
                                            }
                                            else if (j == 3 && k == 9 && i != 6)
                                            {
                                                trash++;
                                            }
                                            else if (j == 9 && k == 3 && i != 6)
                                            {
                                                trash++;
                                            }
                                            else if (j == 1 && k == 9 && i != 5)
                                            {
                                                trash++;
                                            }
                                            else if (j == 9 && k == 1 && i != 5)
                                            {
                                                trash++;
                                            }
                                            else if (j == 3 && k == 7 && i != 5)
                                            {
                                                trash++;
                                            }
                                            else if (j == 7 && k == 3 && i != 5)
                                            {
                                                trash++;
                                            }
                                            else if (k == 1 && l == 3 && (i != 2 && j != 2))
                                            {
                                                trash++;
                                            }
                                            else if (k == 3 && l == 1 && (i != 2 && j != 2))
                                            {
                                                trash++;
                                            }
                                            else if (k == 4 && l == 6 && (i != 5 && j != 5))
                                            {
                                                trash++;
                                            }
                                            else if (k == 6 && l == 4 && (i != 5 && j != 5))
                                            {
                                                trash++;
                                            }
                                            else if (k == 7 && l == 9 && (i != 8 && j != 8))
                                            {
                                                trash++;
                                            }
                                            else if (k == 9 && l == 7 && (i != 8 && j != 8))
                                            {
                                                trash++;
                                            }
                                            else if (k == 1 && l == 7 && (i != 4 && j != 4))
                                            {
                                                trash++;
                                            }
                                            else if (k == 7 && l == 1 && (i != 4 && j != 4))
                                            {
                                                trash++;
                                            }
                                            else if (k == 2 && l == 8 && (i != 5 && j != 5))
                                            {
                                                trash++;
                                            }
                                            else if (k == 8 && l == 2 && (i != 5 && j != 5))
                                            {
                                                trash++;
                                            }
                                            else if (k == 3 && l == 9 && (i != 6 && j != 6))
                                            {
                                                trash++;
                                            }
                                            else if (k == 9 && l == 3 && (i != 6 && j != 6))
                                            {
                                                trash++;
                                            }
                                            else if (k == 1 && l == 9 && (i != 5 && j != 5))
                                            {
                                                trash++;
                                            }
                                            else if (k == 9 && l == 1 && (i != 5 && j != 5))
                                            {
                                                trash++;
                                            }
                                            else if (k == 3 && l == 7 && (i != 5 && j != 5))
                                            {
                                                trash++;
                                            }
                                            else if (k == 7 && l == 3 && (i != 5 && j != 5))
                                            {
                                                trash++;
                                            }
                                            else if (l == 1 && f == 3 && (i != 2 && j != 2 && k != 2))
                                            {
                                                trash++;
                                            }
                                            else if (l == 3 && f == 1 && (i != 2 && j != 2 && k != 2))
                                            {
                                                trash++;
                                            }
                                            else if (l == 4 && f == 6 && (i != 5 && j != 5 && k != 5))
                                            {
                                                trash++;
                                            }
                                            else if (l == 6 && f == 4 && (i != 5 && j != 5 && k != 5))
                                            {
                                                trash++;
                                            }
                                            else if (l == 7 && f == 9 && (i != 8 && j != 8 && k != 8))
                                            {
                                                trash++;
                                            }
                                            else if (l == 9 && f == 7 && (i != 8 && j != 8 && k != 8))
                                            {
                                                trash++;
                                            }
                                            else if (l == 1 && f == 7 && (i != 4 && j != 4 && k != 4))
                                            {
                                                trash++;
                                            }
                                            else if (l == 7 && f == 1 && (i != 4 && j != 4 && k != 4))
                                            {
                                                trash++;
                                            }
                                            else if (l == 2 && f == 8 && (i != 5 && j != 5 && k != 5))
                                            {
                                                trash++;
                                            }
                                            else if (l == 8 && f == 2 && (i != 5 && j != 5 && k != 5))
                                            {
                                                trash++;
                                            }
                                            else if (l == 3 && f == 9 && (i != 6 && j != 6 && k != 6))
                                            {
                                                trash++;
                                            }
                                            else if (l == 9 && f == 3 && (i != 6 && j != 6 && k != 6))
                                            {
                                                trash++;
                                            }
                                            else if (l == 1 && f == 9 && (i != 5 && j != 5 && k != 5))
                                            {
                                                trash++;
                                            }
                                            else if (l == 9 && f == 1 && (i != 5 && j != 5 && k != 5))
                                            {
                                                trash++;
                                            }
                                            else if (l == 3 && f == 7 && (i != 5 && j != 5 && k != 5))
                                            {
                                                trash++;
                                            }
                                            else if (l == 7 && f == 3 && (i != 5 && j != 5 && k != 5))
                                            {
                                                trash++;
                                            }
                                            else if (f == 1 && t == 3 && (i != 2 && j != 2 && k != 2 && l != 2))
                                            {
                                                trash++;
                                            }
                                            else if (f == 3 && t == 1 && (i != 2 && j != 2 && k != 2 && l != 2))
                                            {
                                                trash++;
                                            }
                                            else if (f == 4 && t == 6 && (i != 5 && j != 5 && k != 5 && l != 5))
                                            {
                                                trash++;
                                            }
                                            else if (f == 6 && t == 4 && (i != 5 && j != 5 && k != 5 && l != 5))
                                            {
                                                trash++;
                                            }
                                            else if (f == 7 && t == 9 && (i != 8 && j != 8 && k != 8 && l != 8))
                                            {
                                                trash++;
                                            }
                                            else if (f == 9 && t == 7 && (i != 8 && j != 8 && k != 8 && l != 8))
                                            {
                                                trash++;
                                            }
                                            else if (f == 1 && t == 7 && (i != 4 && j != 4 && k != 4 && l != 4))
                                            {
                                                trash++;
                                            }
                                            else if (f == 7 && t == 1 && (i != 4 && j != 4 && k != 4 && l != 4))
                                            {
                                                trash++;
                                            }
                                            else if (f == 2 && t == 8 && (i != 5 && j != 5 && k != 5 && l != 5))
                                            {
                                                trash++;
                                            }
                                            else if (f == 8 && t == 2 && (i != 5 && j != 5 && k != 5 && l != 5))
                                            {
                                                trash++;
                                            }
                                            else if (f == 3 && t == 9 && (i != 6 && j != 6 && k != 6 && l != 6))
                                            {
                                                trash++;
                                            }
                                            else if (f == 9 && t == 3 && (i != 6 && j != 6 && k != 6 && l != 6))
                                            {
                                                trash++;
                                            }
                                            else if (f == 1 && t == 9 && (i != 5 && j != 5 && k != 5 && l != 5))
                                            {
                                                trash++;
                                            }
                                            else if (f == 9 && t == 1 && (i != 5 && j != 5 && k != 5 && l != 5))
                                            {
                                                trash++;
                                            }
                                            else if (f == 3 && t == 7 && (i != 5 && j != 5 && k != 5 && l != 5))
                                            {
                                                trash++;
                                            }
                                            else if (f == 7 && t == 3 && (i != 5 && j != 5 && k != 5 && l != 5))
                                            {
                                                trash++;
                                            }
                                            else if (t == 1 && h == 3 && (i != 2 && j != 2 && k != 2 && l != 2 && f != 2))
                                            {
                                                trash++;
                                            }
                                            else if (t == 3 && h == 1 && (i != 2 && j != 2 && k != 2 && l != 2 && f != 2))
                                            {
                                                trash++;
                                            }
                                            else if (t == 4 && h == 6 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5))
                                            {
                                                trash++;
                                            }
                                            else if (t == 6 && h == 4 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5))
                                            {
                                                trash++;
                                            }
                                            else if (t == 7 && h == 9 && (i != 8 && j != 8 && k != 8 && l != 8 && f != 8))
                                            {
                                                trash++;
                                            }
                                            else if (t == 9 && h == 7 && (i != 8 && j != 8 && k != 8 && l != 8 && f != 8))
                                            {
                                                trash++;
                                            }
                                            else if (t == 1 && h == 7 && (i != 4 && j != 4 && k != 4 && l != 4 && f != 4))
                                            {
                                                trash++;
                                            }
                                            else if (t == 7 && h == 1 && (i != 4 && j != 4 && k != 4 && l != 4 && f != 4))
                                            {
                                                trash++;
                                            }
                                            else if (t == 2 && h == 8 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5))
                                            {
                                                trash++;
                                            }
                                            else if (t == 8 && h == 2 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5))
                                            {
                                                trash++;
                                            }
                                            else if (t == 3 && h == 9 && (i != 6 && j != 6 && k != 6 && l != 6 && f != 6))
                                            {
                                                trash++;
                                            }
                                            else if (t == 9 && h == 3 && (i != 6 && j != 6 && k != 6 && l != 6 && f != 6))
                                            {
                                                trash++;
                                            }
                                            else if (t == 1 && h == 9 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5))
                                            {
                                                trash++;
                                            }
                                            else if (t == 9 && h == 1 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5))
                                            {
                                                trash++;
                                            }
                                            else if (t == 3 && h == 7 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5))
                                            {
                                                trash++;
                                            }
                                            else if (t == 7 && h == 3 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5))
                                            {
                                                trash++;
                                            }
                                            else if (h == 1 && g == 3 && (i != 2 && j != 2 && k != 2 && l != 2 && f != 2 && t != 2))
                                            {
                                                trash++;
                                            }
                                            else if (h == 3 && g == 1 && (i != 2 && j != 2 && k != 2 && l != 2 && f != 2 && t != 2))
                                            {
                                                trash++;
                                            }
                                            else if (h == 4 && g == 6 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5 && t != 5))
                                            {
                                                trash++;
                                            }
                                            else if (h == 6 && g == 4 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5 && t != 5))
                                            {
                                                trash++;
                                            }
                                            else if (h == 7 && g == 9 && (i != 8 && j != 8 && k != 8 && l != 8 && f != 8 && t != 8))
                                            {
                                                trash++;
                                            }
                                            else if (h == 9 && g == 7 && (i != 8 && j != 8 && k != 8 && l != 8 && f != 8 && t != 8))
                                            {
                                                trash++;
                                            }
                                            else if (h == 1 && g == 7 && (i != 4 && j != 4 && k != 4 && l != 4 && f != 4 && t != 4))
                                            {
                                                trash++;
                                            }
                                            else if (h == 7 && g == 1 && (i != 4 && j != 4 && k != 4 && l != 4 && f != 4 && t != 4))
                                            {
                                                trash++;
                                            }
                                            else if (h == 2 && g == 8 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5 && t != 5))
                                            {
                                                trash++;
                                            }
                                            else if (h == 8 && g == 2 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5 && t != 5))
                                            {
                                                trash++;
                                            }
                                            else if (h == 3 && g == 9 && (i != 6 && j != 6 && k != 6 && l != 6 && f != 6 && t != 6))
                                            {
                                                trash++;
                                            }
                                            else if (h == 9 && g == 3 && (i != 6 && j != 6 && k != 6 && l != 6 && f != 6 && t != 6))
                                            {
                                                trash++;
                                            }
                                            else if (h == 1 && g == 9 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5 && t != 5))
                                            {
                                                trash++;
                                            }
                                            else if (h == 9 && g == 1 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5 && t != 5))
                                            {
                                                trash++;
                                            }
                                            else if (h == 3 && g == 7 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5 && t != 5))
                                            {
                                                trash++;
                                            }
                                            else if (h == 7 && g == 3 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5 && t != 5))
                                            {
                                                trash++;
                                            }
                                            else
                                            {
                                                globalCounter++;
                                                v8D[counter] = new int[9] {i,j,k,l,f,t,h,g,0};
                                                counter++;
                                            }
                                        }
                                        else
                                        {
                                            trash++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        counter = 0;
        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                for (int k = 1; k <= 9; k++)
                {
                    for (int l = 1; l <= 9; l++)
                    {
                        for (int f = 1; f <= 9; f++)
                        {
                            for (int t = 1; t <= 9; t++)
                            {
                                for (int h = 1; h <= 9; h++)
                                {
                                    for (int g = 1; g <= 9; g++)
                                    {
                                        for (int y = 1; y <= 9; y++)
                                        {

                                            if (i != j && i != k && i != l && i != f && i != t && i != h && i != g && i != y
                                                    && j != k && j != l && j != f && j != t && j != h && j != g && j != y
                                                    && k != l && k != f && k != t && k != h && k != g && k != y
                                                    && l != f && l != t && l != h && l != g && l != y
                                                    && f != t && f != h && f != g && f != y
                                                    && t != h && t != g && t != y
                                                    && h != g && h != y
                                                    && g != y)
                                            {

                                                if ((i == 1 && j == 3) || (i == 4 && j == 6) || (i == 7 && j == 9))
                                                {
                                                    trash++;
                                                }
                                                else if ((i == 3 && j == 1) || (i == 6 && j == 4) || (i == 9 && j == 7))
                                                {
                                                    trash++;
                                                }
                                                else if ((i == 1 && j == 7) || (i == 2 && j == 8) || (i == 3 && j == 9))
                                                {
                                                    trash++;
                                                }
                                                else if ((i == 7 && j == 1) || (i == 8 && j == 2) || (i == 9 && j == 3))
                                                {
                                                    trash++;
                                                }
                                                else if ((i == 1 && j == 9) || (i == 3 && j == 7) || (i == 9 && j == 1) || (i == 7 && j == 3))
                                                {
                                                    trash++;
                                                }
                                                else if (j == 1 && k == 3 && i != 2)
                                                {
                                                    trash++;
                                                }
                                                else if (j == 3 && k == 1 && i != 2)
                                                {
                                                    trash++;
                                                }
                                                else if (j == 4 && k == 6 && i != 5)
                                                {
                                                    trash++;
                                                }
                                                else if (j == 6 && k == 4 && i != 5)
                                                {
                                                    trash++;
                                                }
                                                else if (j == 7 && k == 9 && i != 8)
                                                {
                                                    trash++;
                                                }
                                                else if (j == 9 && k == 7 && i != 8)
                                                {
                                                    trash++;
                                                }
                                                else if (j == 1 && k == 7 && i != 4)
                                                {
                                                    trash++;
                                                }
                                                else if (j == 7 && k == 1 && i != 4)
                                                {
                                                    trash++;
                                                }
                                                else if (j == 2 && k == 8 && i != 5)
                                                {
                                                    trash++;
                                                }
                                                else if (j == 8 && k == 2 && i != 5)
                                                {
                                                    trash++;
                                                }
                                                else if (j == 3 && k == 9 && i != 6)
                                                {
                                                    trash++;
                                                }
                                                else if (j == 9 && k == 3 && i != 6)
                                                {
                                                    trash++;
                                                }
                                                else if (j == 1 && k == 9 && i != 5)
                                                {
                                                    trash++;
                                                }
                                                else if (j == 9 && k == 1 && i != 5)
                                                {
                                                    trash++;
                                                }
                                                else if (j == 3 && k == 7 && i != 5)
                                                {
                                                    trash++;
                                                }
                                                else if (j == 7 && k == 3 && i != 5)
                                                {
                                                    trash++;
                                                }
                                                else if (k == 1 && l == 3 && (i != 2 && j != 2))
                                                {
                                                    trash++;
                                                }
                                                else if (k == 3 && l == 1 && (i != 2 && j != 2))
                                                {
                                                    trash++;
                                                }
                                                else if (k == 4 && l == 6 && (i != 5 && j != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (k == 6 && l == 4 && (i != 5 && j != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (k == 7 && l == 9 && (i != 8 && j != 8))
                                                {
                                                    trash++;
                                                }
                                                else if (k == 9 && l == 7 && (i != 8 && j != 8))
                                                {
                                                    trash++;
                                                }
                                                else if (k == 1 && l == 7 && (i != 4 && j != 4))
                                                {
                                                    trash++;
                                                }
                                                else if (k == 7 && l == 1 && (i != 4 && j != 4))
                                                {
                                                    trash++;
                                                }
                                                else if (k == 2 && l == 8 && (i != 5 && j != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (k == 8 && l == 2 && (i != 5 && j != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (k == 3 && l == 9 && (i != 6 && j != 6))
                                                {
                                                    trash++;
                                                }
                                                else if (k == 9 && l == 3 && (i != 6 && j != 6))
                                                {
                                                    trash++;
                                                }
                                                else if (k == 1 && l == 9 && (i != 5 && j != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (k == 9 && l == 1 && (i != 5 && j != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (k == 3 && l == 7 && (i != 5 && j != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (k == 7 && l == 3 && (i != 5 && j != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (l == 1 && f == 3 && (i != 2 && j != 2 && k != 2))
                                                {
                                                    trash++;
                                                }
                                                else if (l == 3 && f == 1 && (i != 2 && j != 2 && k != 2))
                                                {
                                                    trash++;
                                                }
                                                else if (l == 4 && f == 6 && (i != 5 && j != 5 && k != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (l == 6 && f == 4 && (i != 5 && j != 5 && k != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (l == 7 && f == 9 && (i != 8 && j != 8 && k != 8))
                                                {
                                                    trash++;
                                                }
                                                else if (l == 9 && f == 7 && (i != 8 && j != 8 && k != 8))
                                                {
                                                    trash++;
                                                }
                                                else if (l == 1 && f == 7 && (i != 4 && j != 4 && k != 4))
                                                {
                                                    trash++;
                                                }
                                                else if (l == 7 && f == 1 && (i != 4 && j != 4 && k != 4))
                                                {
                                                    trash++;
                                                }
                                                else if (l == 2 && f == 8 && (i != 5 && j != 5 && k != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (l == 8 && f == 2 && (i != 5 && j != 5 && k != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (l == 3 && f == 9 && (i != 6 && j != 6 && k != 6))
                                                {
                                                    trash++;
                                                }
                                                else if (l == 9 && f == 3 && (i != 6 && j != 6 && k != 6))
                                                {
                                                    trash++;
                                                }
                                                else if (l == 1 && f == 9 && (i != 5 && j != 5 && k != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (l == 9 && f == 1 && (i != 5 && j != 5 && k != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (l == 3 && f == 7 && (i != 5 && j != 5 && k != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (l == 7 && f == 3 && (i != 5 && j != 5 && k != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (f == 1 && t == 3 && (i != 2 && j != 2 && k != 2 && l != 2))
                                                {
                                                    trash++;
                                                }
                                                else if (f == 3 && t == 1 && (i != 2 && j != 2 && k != 2 && l != 2))
                                                {
                                                    trash++;
                                                }
                                                else if (f == 4 && t == 6 && (i != 5 && j != 5 && k != 5 && l != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (f == 6 && t == 4 && (i != 5 && j != 5 && k != 5 && l != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (f == 7 && t == 9 && (i != 8 && j != 8 && k != 8 && l != 8))
                                                {
                                                    trash++;
                                                }
                                                else if (f == 9 && t == 7 && (i != 8 && j != 8 && k != 8 && l != 8))
                                                {
                                                    trash++;
                                                }
                                                else if (f == 1 && t == 7 && (i != 4 && j != 4 && k != 4 && l != 4))
                                                {
                                                    trash++;
                                                }
                                                else if (f == 7 && t == 1 && (i != 4 && j != 4 && k != 4 && l != 4))
                                                {
                                                    trash++;
                                                }
                                                else if (f == 2 && t == 8 && (i != 5 && j != 5 && k != 5 && l != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (f == 8 && t == 2 && (i != 5 && j != 5 && k != 5 && l != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (f == 3 && t == 9 && (i != 6 && j != 6 && k != 6 && l != 6))
                                                {
                                                    trash++;
                                                }
                                                else if (f == 9 && t == 3 && (i != 6 && j != 6 && k != 6 && l != 6))
                                                {
                                                    trash++;
                                                }
                                                else if (f == 1 && t == 9 && (i != 5 && j != 5 && k != 5 && l != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (f == 9 && t == 1 && (i != 5 && j != 5 && k != 5 && l != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (f == 3 && t == 7 && (i != 5 && j != 5 && k != 5 && l != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (f == 7 && t == 3 && (i != 5 && j != 5 && k != 5 && l != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (t == 1 && h == 3 && (i != 2 && j != 2 && k != 2 && l != 2 && f != 2))
                                                {
                                                    trash++;
                                                }
                                                else if (t == 3 && h == 1 && (i != 2 && j != 2 && k != 2 && l != 2 && f != 2))
                                                {
                                                    trash++;
                                                }
                                                else if (t == 4 && h == 6 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (t == 6 && h == 4 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (t == 7 && h == 9 && (i != 8 && j != 8 && k != 8 && l != 8 && f != 8))
                                                {
                                                    trash++;
                                                }
                                                else if (t == 9 && h == 7 && (i != 8 && j != 8 && k != 8 && l != 8 && f != 8))
                                                {
                                                    trash++;
                                                }
                                                else if (t == 1 && h == 7 && (i != 4 && j != 4 && k != 4 && l != 4 && f != 4))
                                                {
                                                    trash++;
                                                }
                                                else if (t == 7 && h == 1 && (i != 4 && j != 4 && k != 4 && l != 4 && f != 4))
                                                {
                                                    trash++;
                                                }
                                                else if (t == 2 && h == 8 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (t == 8 && h == 2 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (t == 3 && h == 9 && (i != 6 && j != 6 && k != 6 && l != 6 && f != 6))
                                                {
                                                    trash++;
                                                }
                                                else if (t == 9 && h == 3 && (i != 6 && j != 6 && k != 6 && l != 6 && f != 6))
                                                {
                                                    trash++;
                                                }
                                                else if (t == 1 && h == 9 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (t == 9 && h == 1 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (t == 3 && h == 7 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (t == 7 && h == 3 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (h == 1 && g == 3 && (i != 2 && j != 2 && k != 2 && l != 2 && f != 2 && t != 2))
                                                {
                                                    trash++;
                                                }
                                                else if (h == 3 && g == 1 && (i != 2 && j != 2 && k != 2 && l != 2 && f != 2 && t != 2))
                                                {
                                                    trash++;
                                                }
                                                else if (h == 4 && g == 6 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5 && t != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (h == 6 && g == 4 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5 && t != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (h == 7 && g == 9 && (i != 8 && j != 8 && k != 8 && l != 8 && f != 8 && t != 8))
                                                {
                                                    trash++;
                                                }
                                                else if (h == 9 && g == 7 && (i != 8 && j != 8 && k != 8 && l != 8 && f != 8 && t != 8))
                                                {
                                                    trash++;
                                                }
                                                else if (h == 1 && g == 7 && (i != 4 && j != 4 && k != 4 && l != 4 && f != 4 && t != 4))
                                                {
                                                    trash++;
                                                }
                                                else if (h == 7 && g == 1 && (i != 4 && j != 4 && k != 4 && l != 4 && f != 4 && t != 4))
                                                {
                                                    trash++;
                                                }
                                                else if (h == 2 && g == 8 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5 && t != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (h == 8 && g == 2 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5 && t != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (h == 3 && g == 9 && (i != 6 && j != 6 && k != 6 && l != 6 && f != 6 && t != 6))
                                                {
                                                    trash++;
                                                }
                                                else if (h == 9 && g == 3 && (i != 6 && j != 6 && k != 6 && l != 6 && f != 6 && t != 6))
                                                {
                                                    trash++;
                                                }
                                                else if (h == 1 && g == 9 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5 && t != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (h == 9 && g == 1 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5 && t != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (h == 3 && g == 7 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5 && t != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (h == 7 && g == 3 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5 && t != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (g == 1 && y == 3 && (i != 2 && j != 2 && k != 2 && l != 2 && f != 2 && t != 2 && h != 2))
                                                {
                                                    trash++;
                                                }
                                                else if (g == 3 && y == 1 && (i != 2 && j != 2 && k != 2 && l != 2 && f != 2 && t != 2 && h != 2))
                                                {
                                                    trash++;
                                                }
                                                else if (g == 4 && y == 6 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5 && t != 5 && h != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (g == 6 && y == 4 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5 && t != 5 && h != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (g == 7 && y == 9 && (i != 8 && j != 8 && k != 8 && l != 8 && f != 8 && t != 8 && h != 8))
                                                {
                                                    trash++;
                                                }
                                                else if (g == 9 && y == 7 && (i != 8 && j != 8 && k != 8 && l != 8 && f != 8 && t != 8 && h != 8))
                                                {
                                                    trash++;
                                                }
                                                else if (g == 1 && y == 7 && (i != 4 && j != 4 && k != 4 && l != 4 && f != 4 && t != 4 && h != 4))
                                                {
                                                    trash++;
                                                }
                                                else if (g == 7 && y == 1 && (i != 4 && j != 4 && k != 4 && l != 4 && f != 4 && t != 4 && h != 4))
                                                {
                                                    trash++;
                                                }
                                                else if (g == 2 && y == 8 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5 && t != 5 && h != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (g == 8 && y == 2 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5 && t != 5 && h != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (g == 3 && y == 9 && (i != 6 && j != 6 && k != 6 && l != 6 && f != 6 && t != 6 && h != 6))
                                                {
                                                    trash++;
                                                }
                                                else if (g == 9 && y == 3 && (i != 6 && j != 6 && k != 6 && l != 6 && f != 6 && t != 6 && h != 6))
                                                {
                                                    trash++;
                                                }
                                                else if (g == 1 && y == 9 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5 && t != 5 && h != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (g == 9 && y == 1 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5 && t != 5 && h != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (g == 3 && y == 7 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5 && t != 5 && h != 5))
                                                {
                                                    trash++;
                                                }
                                                else if (g == 7 && y == 3 && (i != 5 && j != 5 && k != 5 && l != 5 && f != 5 && t != 5 && h != 5))
                                                {
                                                    trash++;
                                                }
                                                else
                                                {
                                                    globalCounter++;
                                                    v9D[counter] = new int[9] {i,j,k,l,f,t,h,g,y};
                                                    counter++;
                                                }
                                            }
                                            else
                                            {
                                                trash++;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        counter = 0;
        
        posCombText.GetComponent<TMPro.TextMeshProUGUI>().text = ("Possible Combinations: " + globalCounter.ToString());

        rand = Random.Range(4,10);
        switch(rand){
            case 4:
                rand = Random.Range(0,v4D.Length);
                codeText.GetComponent<TMPro.TextMeshProUGUI>().text = ("Code: " + v4D[rand][0].ToString() + v4D[rand][1].ToString() + v4D[rand][2].ToString() + v4D[rand][3].ToString());
                line.positionCount = 4;
                for(int i = 0; i < 4; i++){
                    circlesPanel.transform.GetChild(v4D[rand][i]+8).gameObject.SetActive(true);
                    line.SetPosition(i, circlesPanel.transform.GetChild(v4D[rand][i]+8).gameObject.transform.position);
                }
                break;
            case 5:
                rand = Random.Range(0,v5D.Length);
                codeText.GetComponent<TMPro.TextMeshProUGUI>().text = ("Code: " + v5D[rand][0].ToString() + v5D[rand][1].ToString() + v5D[rand][2].ToString() + v5D[rand][3].ToString() + v5D[rand][4].ToString());
                line.positionCount = 5;
                for(int i = 0; i < 5; i++){
                    circlesPanel.transform.GetChild(v5D[rand][i]+8).gameObject.SetActive(true);
                    line.SetPosition(i, circlesPanel.transform.GetChild(v5D[rand][i]+8).gameObject.transform.position);
                }
                break;
            case 6:
                rand = Random.Range(0,v6D.Length);
                codeText.GetComponent<TMPro.TextMeshProUGUI>().text = ("Code: " + v6D[rand][0].ToString() + v6D[rand][1].ToString() + v6D[rand][2].ToString() + v6D[rand][3].ToString() + v6D[rand][4].ToString() + v6D[rand][5].ToString());
                line.positionCount = 6;
                for(int i = 0; i < 6; i++){
                    circlesPanel.transform.GetChild(v6D[rand][i]+8).gameObject.SetActive(true);
                    line.SetPosition(i, circlesPanel.transform.GetChild(v6D[rand][i]+8).gameObject.transform.position);
                }
                break;
            case 7:
                rand = Random.Range(0,v7D.Length);
                codeText.GetComponent<TMPro.TextMeshProUGUI>().text = ("Code: " + v7D[rand][0].ToString() + v7D[rand][1].ToString() + v7D[rand][2].ToString() + v7D[rand][3].ToString() + v7D[rand][4].ToString() + v7D[rand][5].ToString() + v7D[rand][6].ToString());
                line.positionCount = 7;
                for(int i = 0; i < 7; i++){
                    circlesPanel.transform.GetChild(v7D[rand][i]+8).gameObject.SetActive(true);
                    line.SetPosition(i, circlesPanel.transform.GetChild(v7D[rand][i]+8).gameObject.transform.position);
                }
                break;
            case 8:
                rand = Random.Range(0,v8D.Length + 1);
                codeText.GetComponent<TMPro.TextMeshProUGUI>().text = ("Code: " + v8D[rand][0].ToString() + v8D[rand][1].ToString() + v8D[rand][2].ToString() + v8D[rand][3].ToString() + v8D[rand][4].ToString() + v8D[rand][5].ToString() + v8D[rand][6].ToString() + v8D[rand][7].ToString());
                line.positionCount = 8;
                for(int i = 0; i < 8; i++){
                    circlesPanel.transform.GetChild(v8D[rand][i]+8).gameObject.SetActive(true);
                    line.SetPosition(i, circlesPanel.transform.GetChild(v8D[rand][i]+8).gameObject.transform.position);
                }
                break;
            case 9:
                rand = Random.Range(0,v9D.Length + 1);
                codeText.GetComponent<TMPro.TextMeshProUGUI>().text = ("Code: " + v9D[rand][0].ToString() + v9D[rand][1].ToString() + v9D[rand][2].ToString() + v9D[rand][3].ToString() + v9D[rand][4].ToString() + v9D[rand][5].ToString() + v9D[rand][6].ToString() + v9D[rand][7].ToString() + v9D[rand][8].ToString());
                line.positionCount = 9;
                for(int i = 0; i < 9; i++){
                    circlesPanel.transform.GetChild(v9D[rand][i]+8).gameObject.SetActive(true);
                    line.SetPosition(i, circlesPanel.transform.GetChild(v9D[rand][i]+8).gameObject.transform.position);
                }
                break;
            default:
                break;
        }
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)){
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
    }
}