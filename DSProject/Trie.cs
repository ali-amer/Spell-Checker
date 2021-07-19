using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSProject
{
    public class Trie
    {
        public class Node
        {
            public Node[] children;
            public bool isEnd = false;
            public Node()
            {
                children = new Node[26];
                isEnd = false;
            }
        }
        public Node root = null;
        public Trie()
        {
            root = new Node();
        }
        public void insert(string word)
        {
            Node currNode = root;
            for (int i = 0; i < word.Length; ++i)
            {
                if (currNode.children[word[i] - 'a'] == null)
                {
                    currNode.children[word[i] - 'a'] = new Node();
                }
                currNode = currNode.children[word[i] - 'a'];
            }
            currNode.isEnd = true;
        }
        public bool Search(String word)
        {
            Node currNode = root;
            for (int i = 0; i < word.Length; i++)
            {
                if (currNode.children[word[i] - 'a'] == null)
                {
                    return false;
                }
                currNode = currNode.children[word[i] - 'a'];
            }
            return currNode.isEnd;
        }

        /** Returns if there is any word in the trie that starts with the given prefix. */
        public bool StartsWith(String prefix)
        {
            Node currNode = root;
            for (int i = 0; i < prefix.Length; i++)
            {
                if (currNode.children[prefix[i] - 'a'] == null)
                {
                    return false;
                }
                currNode = currNode.children[prefix[i] - 'a'];
            }
            return true;
        }
        public bool Deletion(String prefix)
        {
            Node currNode = root;
            if(currNode==null)
            {
                return false;
            }
            for (int i = 0; i < prefix.Length; i++)
            {
                if (currNode.children[prefix[i] - 'a'] == null && Deletion(prefix) && currNode.isEnd)
                {
                    currNode = null;
                    return true;
                }
                else
                {
                    return false;
                }
                currNode = currNode.children[prefix[i] - 'a'];
            }
            return true;
        }
       
        
    }
}
