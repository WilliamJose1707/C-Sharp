/* Atalhos Visual Studio */
Ctrl + K + D: identa todo o seu código automaticamente;

Ctrl + K + C: comenta um bloco de linhas;

Ctrl + K + U: descomenta um bloco de linhas;

Ctrl + Shift + Arrow Up: durante a programação, volta um método que você estava navegando;

Ctrl + Shift + Arrow Down: durante a programação, avança um método que você estava navegando;

Ctrl + .: implementa o método/classe inexistente que você acabou de escrever;

Ctrl + M + O: esconde todas as regions da classe atual;

Ctrl + Shift + B: compila todos os projetos;

F5: manda depurar um projeto;

Ctrl + F5: manda executar um projeto;

F10: durante a depuração, avança uma linha;

F11: durante a depuração, avança uma linha entrando nos detalhes da mesma;



/* Snippets */

Usar comandos abaixo seguidos de um TAB

for: monta um laço for padrão;

if: monta uma estrutura if padrão;

ctor: monta um construtor vazio para a classe atual;

cw: chama um Console.WriteLine();

do: cria um bloco do/while;

equals: sobrescreve o método equals de Object;

foreach: monta um laço foreach padrão;

try: cria um bloco try/catch padrão;

while: cria um bloco while padrão;



2- Comparando Strings utilizando o Non-Case-Sensitive

//Forma tradicional
str1.ToLower() == str2.ToLower()
Porém usar repetidamente a função ToLower() afeta o desempenho.

// Melhor forma usando a função string.Compare()
// A função string.Compare() retorna um inteiro que é igual a 0 quando as duas strings forem iguais.

string.Compare(str1, str2, true) == 0


3- Utilize String.Empty ao invés de " "

Ao invés de usar:
//Tradicional
if (str1 == "")

//Melhor forma de usar

if (str1 == string.Empty)

