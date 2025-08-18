using System;


namespace TabelaHash{
    public class HashTable{
        private int size;
        private int[] keys;
        private int[] values;
        private bool[] isOccupied;
        private int count;


        public HashTable(int size){
            this.size = size;
            this.keys = new int[size];
            this.values = new int[size];
            this.isOccupied = new bool[size];
        }


        public int Size{
            get{
                return count;
            }
        }


        public bool IsEmpty(){
            int count = 0;

            for (int i = 0; i < size; i++){
                if (isOccupied[i]){
                    count++;
                }
            }

            return count == 0;
        }


        private int LinearProbing(int key){
            return key % size;
        }


        private int HashDuplo(int key){
            return 7 - (key % 7);
        }


        private void Rehash(){
            int newSize = size * 2;
            int[] newKeys = new int[newSize];
            int[] newValues = new int[newSize];
            bool[] newIsOccupied = new bool[newSize];
            int newCount = 0;


            for (int i = 0; i < size; i++){
                if (isOccupied[i]){
                    int key = keys[i];
                    int value = values[i];
                    int index = LinearProbing(key);
                    int step = HashDuplo(key);

                    while (newIsOccupied[index]){
                        index = (index + step) % newSize;
                    }

                    newKeys[index] = key;
                    newValues[index] = value;
                    newIsOccupied[index] = true;
                    newCount++;
                }
            }

            size = newSize;
            keys = newKeys;
            values = newValues;
            isOccupied = newIsOccupied;
            count = newCount;
        }


        public void InsertElement(int key, int value){
            // Verifica o fator de carga (alfa)
            if ((double)count / size >= 0.7){
                Rehash();
            }

            int index = LinearProbing(key);
            int step = HashDuplo(key);

            while (isOccupied[index]){
                index = (index + step) % size;
            }

            keys[index] = key;
            values[index] = value;
            isOccupied[index] = true;
            count++;
        }


        public int FindElement(int key){
            int index = LinearProbing(key);
            int step = HashDuplo(key);

            while (isOccupied[index]){
                if (keys[index] == key){
                    return values[index];
                }

                index = (index + step) % size;
            }

            return -1;
        }


        public void Remove(int key){
            int index = LinearProbing(key);
            int step = HashDuplo(key);

            while (isOccupied[index]){
                if (keys[index] == key){
                    isOccupied[index] = false;
                    count--;
                    break;
                }

                index = (index + step) % size;
            }
        }


        public void Print(){
            for (int i = 0; i < size; i++){
                if (isOccupied[i]){
                    Console.WriteLine("Key: " + keys[i] + ", Value: " + values[i]);
                }
            }
        }
    }
}
