using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySlides : MonoBehaviour
{
	
	SpriteRenderer spriteRenderer;
	
	public List<SlideOrder> slides = new List<SlideOrder>();
	
	void Start(){
		spriteRenderer = this.GetComponent<SpriteRenderer>();
		
		StartCoroutine(Sequence());
	}
	
    void ChangeSprite(int x){
		spriteRenderer.sprite = slides[x].slide;
	}
	
	IEnumerator Sequence(){
		
		for (int curSlide = 0; curSlide < slides.Count; curSlide++){
			
			ChangeSprite(curSlide);
			
			yield return new WaitForSeconds(slides[curSlide].holdTime);
			
		}
	}
}