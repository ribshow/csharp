# Aula 23-09-2024 

## Exceção

**Tratamento de exceções**

**try / catch / finally**
- try - código que pode gerar exceções (um try)
- catch - tratamento da exceção (várias catch) [opcional]
- finally - elemento final (um finally) [opcional]

**throw**
- O throw procura exceções pelo código, e as executa
- é possível adicinar filtro para a exceção e escolher quando você quer usar a exceção

- throw new Exception()
- throw new Exception("mensagem")
- throw NotImplomentException()
- throw ArgumentException()
- throw NullReferenceException()
- throw FormatException()
- throw InvalidCastException()
- throw FileNotFoundException()

**Regras para criar tratamento de exceções personalizado**
- Deve herdar System.Exception
- O nome da classe deve terminar com Exception
- Implantar obrigatoriamente 3 métodos construtores
