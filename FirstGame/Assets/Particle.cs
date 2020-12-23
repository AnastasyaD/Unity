using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
  [SerializeField] private ParticleSystem particleSystem;

  public void Update()
  {
      particleSystem.Play();
  }
}
