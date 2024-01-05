import os
import time

# Variáveis ===============================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================

A = ["   As coisas lindas que eu tenho pra te dizer dessa vez são...", "  \n   Eu tenho orgulho de você", "   Eu tenho orgulho de ter te conhecido", "   Eu tenho orgulho de te mandar emails tão lindos quanto cartas todo ano nessa mesma data", "   Eu tenho orgulho de você por ter mudado tanto desde quando eu te conheci", "   Eu tenho orgulho de você por ter aguentado tanto sacode do mundo e ainda continuar sendo você", "   Eu tenho orgulho de você por ser incompreendida pelas pessoas, por você não é igual a elas", "   Eu tenho orgulho de dizer que você fez uma diferença muito grande na minha vida e de como eu a enxergo", "   Assim como também me orgulho de dizer que sou seu amigo, e que sou uma pessoa importante pra você", " \n   Eu me orgulho muito por conseguir te entender, de ser a pessoa na qual você procura quando precisa desabafar. Desde concordar, até discordar.", "  Desde os sonhos estranhos, da conexão inexplicável, até às madrugadas que a gente passa conversando sobre qualquer coisa. \n \n"]

B = ["   Eu não acho você uma alienígena ( a gente já teve essa conversa rsrsrs )", " Mas também não acho que você pertença a este mundo, e o mesmo digo pra mim, pois se assim fosse, o mundo nos amaria, correto? Sabemos que não é assim que acontece. Afinal o mundo ama o que é seu, já o que não é, é rejeitado, escanteado e incompreendido.", "   Não se sinta mal por ser assim.", "   Eu não me sinto. Pelo contrário, eu tenho orgulho disso. Sabe por quê?", "   Porque foi isso que eu aprendi com você.", " \n   Depois de te conhecer, foi que eu aprendi a amar ser quem eu sou. Sem dar importância pro que os outros pensam de mim, pois eu não vivo de opiniões, aceitação, popularidade nem nada do tipo.", "   Se eu tiver só uma pessoa que me enxergue, que me admire, e que me faça sentir que eu não sou o único estranho no mundo, pra mim já basta.", "   E se eu tivesse que imaginar quem é essa pessoa, seria você.\n \n"]

C = ["   Não podemos dizer que uma estrela brilha se não há ninguém que a enxergue.", "   Eu enxergo", "   Brilhe, minha amiga! Mas não como uma estrela, como um quasar, como um vagalume, uma lâmpada ou uma vela. Brilhe como Giselle.", "   Brilhe sendo quem você é.", "   Eu sei que há pessoas que te enxergarão como Giselle.", "   Assim como eu enxergo.", " \n   Te amo, Gih", "   Feliz aniversário \n \n"]

D = ["P.S.:", "   Hoje é um dia muito especial!", "   De presente de aniversário eu já te dei meu primeiro desenho realista, música ao vivo de violão, Flores de origami, um livro e um quadro 100% artesanal, como minha maior e melhor obra como artista.", "   O curioso é que toda vez que eu faço algo pra você é uma novidade tanto pra você que recebe, quanto pra mim que sempre aprendo e busco ir além do que eu já sei só pra te presentear.", "   Bom...  dessa vez eu não tenho nada físico pra você, na verdade nem fisicamente eu poderei estar presente, pois eu trabalho, faço faculdade e sei que você também tem o seu tempo.  ", "   Por outro lado, eu jamais poderia deixar passar essa data em branco, pois apesar das limitações, esse ano tem novidade sim!", "   Espero que você goste tanto quanto eu.", " \n   Ass - Thayso"]

# Inicio da interação =====================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================

print("    Thayso: eu tive uma ideia! \n No lugar de escrever muito e pensar em cada detalhe, vou reaproveitar mensagens que eu já escrevi. \n \n    E já que só tu vai testar mesmo, então vai ser um exclusivo só pra tu...")

intro = input("   Podemos começar? (sim) ").upper()

    # Laço de repetição para obrigar o usuário a dizer 'sim' ==============================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================

if intro != 'SIM':
       os.system('cls')
       seg = 0
       while seg < 5:
           print(". ")
           time.sleep(1)
           seg += 1
       print("   Desculpe! Meu código, minhas regras kkkkkkkkkkkkkkk \n")
       option = None
       while option != "SIM":
           option = input(" Podemos prosseguir? diga que sim: ").upper()

# Menu de opções | Primeira interação  ====================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================
           
os.system('cls')

comeco = ['               INTRO \n', '    Assim como sempre fiz há 4 anos e continuarei fazendo por muitos e muitos anos... \n.  Feliz aniversário, Giselle!', ' \n.  Nem preciso dizer que você já esperava por um email de aniversário, né? Rsrsrs', '  A cada ano que se passa, a gente se conhece cada vez mais ao ponto de saber o que o outro vai fazer sem nem ter feito ainda.']

for n in comeco:
    print(n)
    time.sleep(3)

print('\n \n Este código está dividido em tópicos. \n Pra qual deles você quer ir? \n   A. Meu orgulho... \n   B. Aprendi com você \n   C. Brilhe! \n   D. P.S. \n')

ler = input("   Ler tópico: ").upper()

# Menu de opções | laço das opções  =======================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================

while True:
    if ler == 'A':              # Opção A
        os.system("cls")
        for n in A:
            print(n)
            time.sleep(3)
        
    elif ler == 'B':            # Opção B
            os.system("cls")
            for n in B:
                print(n)
                time.sleep(3)
                
    elif ler == 'C':            # Opção C
            os.system("cls")
            for n in C:
                print(n)
                time.sleep(3)
        
    elif ler == 'D':            # Opção D
            os.system("cls")
            for n in D:
                print(n)
                time.sleep(3)
                
    elif ler == 'já li tudo':   # Encerrar o programa
            break
        
    else:                       # Tratamento de opção inválida
            os.system('cls')
            print("\n   Essa resposta não é válida ao sistema")
                   
    ler = input(' \n \n Este código está dividido em tópicos. \n Pra qual deles você quer ir? \n   A. Meu orgulho... \n   B. Aprendi com você \n   C. Brilhe! \n   D. P.S. \n \n   Se já leu todos, escreva "já li tudo" para encerrar o código. \n   Ler tópico: ').upper()
    
# Enceramento do código ========================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================

os.system('cls')
end = 0
print('   Encerrando código')
while end < 5:
           print(". ")
           time.sleep(1)
           end += 1

print("   Thayso: Obrigado por testar meu código em python! \n")
time.sleep(2)
