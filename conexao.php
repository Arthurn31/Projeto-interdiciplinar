<?php
// classe é uma estrutura de um objeto contendo atributos e metodos (tabela alunos)
// atributos -> são as características do objeto (nome, endereco)
// metodos -> são as ações do objeto (inserir deletar)

class Conexao
{
    //atributos
    // para conectar um banco tem que ter 4 atributos(servidor, banco, usuario, senha)
    //visibilidade -> private (somente a classe tem acesso) / public (todos os acessos)
    private $server = "localhost";
    private $bd = "trabalho_interdiciplinar";
    private $user = "root";
    private $password = "";
    private $conn = ""; //variavel para receber a conexao

    //metodos / funcao / procedimento -> ações da classe
    public function __construct() //executado sempre que instancia a classe
    {
        try{ //tratamento de execucao do codigo
            //criar nossa conexao com mysql utilizando a classe PDO
            // this -> faz referencia a classe
            // new -> criar uma instancia da classe -> criar um objeto do tipo classe
            $this->conn = new PDO("mysql:host={$this->server};dbname={$this->bd};charset=utf8;",$this->user,$this->password);
        }catch (PDOException $msg){ //se der errado na execucao do comando acima
            echo "Não foi possível conectar ao servidor: ".$msg->getMessage();
        }
    }

    //METODO para executar (insert / update / delete)
    public function executeQuery($comando){
        try {
            // criar variavel p receber comando sql
            $sql = $this->conn->prepare($comando);
            //executar o comando no servidor
            $sql->execute();
            //testar se o comando retornou alguma linha
            if($sql->rowCount() > 0){
                return $sql; //retornar o comando para tela
            }else{ //deu erro na execucao
                return $sql->errorInfo();
            }
        }catch (PDOException $msg){
            echo "Não foi possível conectar ao servidor: ".$msg->getMessage();
        }

    }
    //METODO para executar (insert / update / delete)
    public function executeSelect($comando)
    {
        try {
            // criar variavel p receber comando sql
            $sql = $this->conn->prepare($comando);
            //executar o comando no servidor
            $sql->execute();
            //testar se o comando retornou alguma linha
            if ($sql->rowCount() > 0) {
                //retornar o resultado do select na tela
                // fetchAll -> retornar todos os dados do select
                // fetch_class -> retorar dados no formato linha/coluna (classe) == alunos->NOME
                // fetch_assoc -> retorar dados no formato linha/coluna (vetor) == alunos["NOME"]
                return $sql->fetchAll(PDO::FETCH_CLASS);
            } else { //deu erro na execucao
                return $sql->errorInfo();
            }
        } catch (PDOException $msg) {
            echo "Não foi possível conectar ao servidor: " . $msg->getMessage();
        }
    }
}
?>