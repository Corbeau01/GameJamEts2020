using UnityEngine;
using System.Linq;
using TMPro;

public class BookHandler : MonoBehaviour
{
    public GameObject[] regularBooks;
    public GameObject[] startBooks;
    bool success;
    
    void Update() {
        Verify();
    }
    
    public void Explode() {
        foreach(var obj in regularBooks)
        {
            obj.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            obj.GetComponent<Rigidbody>().AddForce(Random.Range(-16, 16), Random.Range(-16, 16), Random.Range(-16, 16), ForceMode.Impulse);
            obj.gameObject.layer = 11;
        }
    }
    
    void Verify()
    {
        if(success) {return;}
        
        //order books from left to right.
        startBooks = startBooks.OrderBy(book=>book.transform.position.x).ToArray();
        
        //check both vertical alignement and horizontal proximity at once.
        for(int i = 0; i < 4; i++){
            var distance = startBooks[i+1].transform.position - startBooks[i].transform.position;
            if (distance.sqrMagnitude > 1.5) {return;}
        }
        
        //Check if letters are correctly ordered.
        if(startBooks[0].GetComponentInChildren<TextMeshPro>().text != "S")  {
            return; }
            
        if(startBooks[1].GetComponentInChildren<TextMeshPro>().text != "T")  {
            return; }
        
        if(startBooks[2].GetComponentInChildren<TextMeshPro>().text != "A")  {
            return; }
            
        if(startBooks[3].GetComponentInChildren<TextMeshPro>().text != "R")  {
            return; }
            
        foreach(var book in startBooks) { //make books clickable.
            book.GetComponent<BookButton>().action = Options.start;
        }
        success = true;
    }
}
