using System;
using System.Collections.Generic;
/* Group 3
 * Arlina Ramrattan, Neil Reading, Aaron Fernandes, Jay Clipperton
 * Assignment 5 - Ciphering Using Link List
*/
namespace COMP212Group3Assignment5
{
    // CIPHER CLASS
    class Cipher
    {
        // PRIVATE INSTANCE VARIABLES

        private LinkedList<char> _originalLinkList,_keyLinkList;

        // CONSTRUCTOR
        public Cipher()
        {
            // set array lists
            this._originalLinkList = new LinkedList<char>("abcdefghijklmnopqrstuvwxyz ".ToCharArray());
            this._keyLinkList = new LinkedList<char>("tmesfkjaxnovluchzgybwpdriq ".ToCharArray());
        }

        // PUBLIC METHODS
        /// <summary>
        ///     Encrypts a string 
        /// </summary>
        /// <param name="data">String to be encrypted</param>
        /// <returns>A link list char array with the encrypted string</returns>
        public LinkedList<char> Encrypt(String data)
        {
            int index;
            char tmpDataChar;
            LinkedList<char> decodedArrayList = new LinkedList<char>();


            foreach (Char dataChar in data)
            {
                // checks if char is a letter
                // if not then it adds the same char
                // to the list
                if (char.IsLetter(dataChar))
                {

                    index = 0;
                    tmpDataChar = char.ToLower(dataChar);

                    foreach (char ch in this._originalLinkList)
                    {
                        if (tmpDataChar == ch)
                        {
                            break;
                        }
                        index++;

                    }
                    LinkedListNode<char> currentNode = this._keyLinkList.First;
                    for (int i = 0; i <= index; i++)
                    {
                        if (i == index)
                        {
                            break;
                        }
                        currentNode = currentNode.Next;
                    }

                    //checks to see if char was upper
                    if (char.IsUpper(dataChar)){
                        decodedArrayList.AddLast(char.ToUpper(currentNode.Value));
                    }
                    else{
                        decodedArrayList.AddLast(currentNode.Value);
                    }
                }
                else
                {
                    decodedArrayList.AddLast(dataChar);
                }
            }//foreach
            return decodedArrayList;
        }

        /// <summary>
        ///     Decrypts a string 
        /// </summary>
        /// <param name="data">String to be decrypted</param>
        /// <returns></returns>
        public LinkedList<char> Decrypt(String data)
        {
            //data = data.ToLower();
            int index;
            char tmpDataChar;
            LinkedList<char> decodedArrayList = new LinkedList<char>();



            foreach (Char dataChar in data)
            {
                // checks if char is a letter
                // if not then it adds the same char
                // to the list
                if (char.IsLetter(dataChar))
                {
                    index = 0;
                    tmpDataChar = char.ToLower(dataChar);

                    foreach (char keyListChar in this._keyLinkList)
                    {
                        if (tmpDataChar == keyListChar)
                        {
                            break;
                        }
                        index++;

                    }
                    LinkedListNode<char> currentNode = this._originalLinkList.First;
                    for (int i = 0; i <= index; i++)
                    {
                        if (i == index)
                        {
                            break;
                        }
                        currentNode = currentNode.Next;
                    }
                    //checks to see if char was upper
                    if (char.IsUpper(dataChar))
                    {
                        decodedArrayList.AddLast(char.ToUpper(currentNode.Value));
                    }
                    else
                    {
                        decodedArrayList.AddLast(currentNode.Value);
                    }
                }
                else
                {
                    decodedArrayList.AddLast(dataChar);
                }
            }
            return decodedArrayList;
        }

    }
}
