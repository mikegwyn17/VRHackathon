using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowParticle : MonoBehaviour {	
	
      private ParticleSystem _psystem;
         
		void Awake() {
		   _psystem = GetComponent<ParticleSystem>();
		}
         
        void OnTriggerEnter (Collider col)  {
			_psystem.Play();
        }
}
