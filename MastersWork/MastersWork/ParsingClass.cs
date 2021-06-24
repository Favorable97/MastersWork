using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MastersWork {
    class ParsingClass {
        private byte[] mas = new byte[2]; // 0 - открывающие скобки, 1 - закрывающие
        private List<string> lstWithBlocks = new List<string>(); // контейнер с блоками циклов
        public List<string> lstWithTypeIter = new List<string>(); // контейнер, где хранятся типы итераторов/контейнеров C++
        public Dictionary<string, string> infoContainers = new Dictionary<string, string>(); // массив, который будет передаваться в основную программу, содержащий имя и тип данных контейнера
        private List<int> indexList = new List<int>(); // контейнер с номерами строк циклов
        public List<int> countOperationFindElement = new List<int>(); // массив, который будет передаваться в основную программу, содержащий число операций поиска
        public List<int> indexStrContainers = new List<int>(); // массив, который будет передаваться в основную программу, содержащий строки, где указан неоптимизированный код
        private string ProgramText { get; }

        public ParsingClass(string programText) {
            ProgramText = programText;
        }

        /*
         * Разбиваем строку на массив строк, где разделитель - символ перехода на новую строчку.
         * Каждую строчку проверяем, используя регулярное выражение.
         * Если строка подходит, то записываем её во временную строку а также запоминаем строчку с началом цикла. 
         * Так до тех пор, пока не будет найдена последняя закрывающая скобка.
         * mas[0] == mas[1]
         * Дойдя до конца блока, записываем его в специальный список, но прежде форматируем
         */
        public void ParsingText() {
            string[] splitText = ProgramText.Split('\n');
            Regex regex = new Regex(@"\w*for\w*");
            Regex pattern = new Regex(@"\s+");

            for (int i = 0; i < splitText.Length; i++) {
                if (regex.IsMatch(splitText[i])) {
                    indexList.Add(i + 1);
                    string strWithFor = "";
                    do {
                        string str = splitText[i];
                        SearchOpenBracket(str);
                        SearchCloseBracket(str);
                        strWithFor += str;
                        i++;

                    } while (mas[0] != mas[1]);
                    i--;
                    mas[0] = 0;
                    mas[1] = 0;
                    lstWithBlocks.Add(strWithFor);
                }
            }
            SearchIterators(splitText);
        }

        private void SearchOpenBracket(string str) {
            int pos = 0;
            while (str.IndexOf('{', pos) != -1) {
                mas[0]++;
                pos = str.IndexOf('{', pos) + 1;
            }
        }

        private void SearchCloseBracket(string str) {
            int pos = 0;
            while (str.IndexOf('}', pos) != -1) {
                mas[1]++;
                pos = str.IndexOf('}', pos) + 1;
            }
        }

        
        /*Поиск всех контейнеров типа list и vector с помощью регулярных выражений*/
        private void SearchIterators(string[] splitText) {
            Regex regexList = new Regex(@"std::list\w*");
            Regex regexVector = new Regex(@"std::vector\w*");

            for (int i = 0; i < splitText.Length; i++) {
                if (regexList.IsMatch(splitText[i]) || regexVector.IsMatch(splitText[i])) {
                    string containerTypeData = splitText[i].Substring(splitText[i].IndexOf('<') + 1, splitText[i].IndexOf('>') - splitText[i].IndexOf('<') - 1);
                    string containerName = splitText[i].Split(' ', '=', ';')[1];
                    string containerType = splitText[i].Substring(splitText[i].LastIndexOf(':') + 1, splitText[i].IndexOf('<') - splitText[i].LastIndexOf(':') - 1);
                    IdentIterators(containerName, containerTypeData, containerType);
                }
            }
        }

        private void IdentIterators(string name, string typeD, string cType) {
            List<string> tmpMas = new List<string>();
            for (int i = 0; i < lstWithBlocks.Count; i++) {
                Regex regex = new Regex(@"\w*::find");
                if (regex.IsMatch(lstWithBlocks[i])){ 
                    string[] masString = lstWithBlocks[i].Split('\t');
                    for (int j = 2; j < masString.Length; j++) {
                        if (masString[j].Contains(name) && !tmpMas.Contains(name)) {
                            int countOperationFind = Convert.ToInt16(masString[1].Substring(masString[1].IndexOf('<') + 1, masString[1].LastIndexOf(';') - masString[1].IndexOf('<') - 1));
                            indexStrContainers.Add(indexList[i]);
                            countOperationFindElement.Add(countOperationFind);
                            tmpMas.Add(name);
                            infoContainers.Add(name, typeD);
                            lstWithTypeIter.Add(cType);
                            break;
                        }
                    }


                }
            }
        }
    }
}