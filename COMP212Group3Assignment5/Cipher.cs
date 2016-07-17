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
            data = data.ToLower();
            int index;
            LinkedList<char> decodedArrayList = new LinkedList<char>();
            foreach (Char c in data)
            {
                if (char.IsLetter(c))
                {
                    index = 0;
                    foreach (char ch in this._originalLinkList)
                    {
                        if (c == ch)
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

                    decodedArrayList.AddLast(currentNode.Value);
                }
                else
                {
                    decodedArrayList.AddLast(c);
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
            data = data.ToLower();
            int index;
            LinkedList<char> _decodedArrayList = new LinkedList<char>();
            foreach (Char c in data)
            {
                index = 0;
                foreach (char ch in this._keyLinkList)
                {
                    if (c == ch)
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
                _decodedArrayList.AddLast(currentNode.Value);
            }
            return _decodedArrayList;
        }

    }
}
