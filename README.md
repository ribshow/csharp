# Orientação a objetos

## Associação
**O que é?**
- Um relacionamento estrutural básico entre duas ou mais classes, indicando que uma classe usa ou se relaciona a outra classe.
- A associação é representada por uma linha simples que conecta as classes envolvidas.
- Sua cardinalidade geralmente é indicada nos extremos da linha(0..1, 1..*), mostrando quantas instâncias de uma classe estão associadas a outra classe.
- Exemplo: Um aluno está associado a uma turma(um aluno pode estar em várias turmas e uma turma pode ter vários alunos).

## Agregação
**O que é?**
- Uma forma especial de associação que indica que uma classe é parte de outra classe, mas as partes podem existir independentemente do todo.
- A agregação é representada por uma linha com um losango vazio na extremidade que indica o "todo" (a classe agregadora).
- Exemplo: Uma turma é composta por alunos, mas os alunos podem existir sem a turma, o aluno não deixa de existir se a turma for desfeita.

## Composição
**O que é?**
- Uma forma mais forte de agregação, onde uma classe é composta de partes que não podem existir independentemente do todo. Se o "todo" for destruído, suas partes também são destruídas.
- A composição é representada por uma linha com um losango preenchido na extremidade que indica o "todo" (a classe composta).
- Exemplo: Um carro é composto por motor, rodas, portas, etc. Se o carro for destruído, suas partes também são destruídas.
- Exemplo: Um livro pode ser composto de capítulos. Se o livro for destruído, os capítulos também são destruídos.

## Encapsulamento
**O que é?**
- Um conceito de ocultar os detalhes internos de uma classe, expondo apenas o que é necessário por meio de métodos públicos. Protege o estado interno do objeto.
- O encapsulamento é representado por meio de modificadores de acesso (public, private, protected), indicados antes dos atributos e métodos.
- '+' (público): Atributos e métodos públicos podem ser acessados por qualquer classe.
- '-' (privado): Atributos e métodos privados só podem ser acessados pela própria classe.
- '#' (protegido): Atributos e métodos protegidos só podem ser acessados pela própria classe e suas subclasses.
- Exemplo: Uma classe carro pode ter um atributo privado "velocidade" e métodos públicos "acelerar" e "frear" que alteram a velocidade.
- Exemplo: Um classe ContaBancária pode ter seus atributos saldo como privados(-saldo), mas fornecer métodos públicos Depositar(+Depositar) e Sacar(+Sacar) para manipular esse saldo de maneira controlada.

## Herança
**O que é?**
- A herança é uma relação de "é um" entre duas classes, onde a subclasse herda as características e comportamentos da superclasse. Isso significa que a subclasse pode reutilizar o código da superclasse, além de definir suas próprias propriedades e métodos específicos.
- Na relação "é um", uma subclasse é um tipo especializado da sua superclasse. Por exemplo, uma revista é uma forma especializada de publicação.
- A herança é representada por uma linha sólida com um seta não preenchida que aponta da subclasse para a superclasse.
- A subclasse herda todos os atributos e métodos públicos e protegidos da superclasse, mas não os atributos e métodos privados.
- Essa subclasse pode reutilizar os métodos herdados, sobrescrever métodos herdados(polimorfismo) para implementar um comportamento específico e adicionar novos métodos e atributos que são específicos da subclasse.
- Exemplo: Uma classe "Animal" pode ter um método "mover" que é herdado por suas subclasses "Cachorro" e "Gato". A subclasse "Cachorro" pode sobrescrever o método "mover" para "correr" e adicionar um método "latir".
- Exemplo: Uma classe "Veículo" pode ter um atributo "velocidade" e métodos "acelerar" e "frear". A subclasse "Carro" pode herdar esses métodos e atributos e adicionar um método "ligar" e "desligar".