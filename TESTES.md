# Guia de Testes - Projeto Estacionamento

## Como Executar os Testes

### 1. Teste Manual
```cmd
dotnet run
```

**Cenários de Teste:**
1. **Adicionar Veículo:**
   - Digite opção "1"
   - Insira uma placa: "ABC-1234"
   - Verifique mensagem de sucesso

2. **Listar Veículos:**
   - Digite opção "3"
   - Verifique se mostra veículos cadastrados

3. **Remover Veículo:**
   - Digite opção "2"
   - Insira placa existente: "ABC-1234"
   - Insira horas: "3"
   - Verifique cálculo: R$ 11,00 (5,00 + 2,00×3)

4. **Remover Veículo Inexistente:**
   - Digite opção "2"
   - Insira placa não cadastrada: "XYZ-9999"
   - Verifique mensagem de erro

### 2. Testes Unitários
```cmd
# Compilar projeto de testes
dotnet build Estacionamento.Tests/

# Executar todos os testes
dotnet test Estacionamento.Tests/

# Executar com detalhes
dotnet test Estacionamento.Tests/ --verbosity normal
```

### 3. Casos de Teste Cobertos pelos Testes Unitários

**✅ Testes Implementados:**
- Construtor da classe Estacionamento
- Adicionar veículo à lista
- Remover veículo existente com cálculo correto
- Tentar remover veículo inexistente
- Listar veículos quando lista está vazia
- Listar veículos quando há veículos cadastrados
- Cálculo de valores para diferentes cenários:
  - 1 hora: R$ 7,00
  - 0 horas: R$ 5,00
  - 2 horas: R$ 16,00 (com preços diferentes)
  - 4 horas: R$ 15,00 (com preço por hora R$ 2,50)

### 4. Comandos Úteis

```cmd
# Compilar projeto principal
dotnet build

# Executar projeto
dotnet run

# Compilar apenas testes
dotnet build Estacionamento.Tests/

# Executar testes com relatório detalhado
dotnet test --logger "console;verbosity=detailed"

# Executar testes com cobertura (se instalado)
dotnet test --collect:"XPlat Code Coverage"
```

### 5. Validações Importantes

**Funcionalidades Testadas:**
- ✅ Adição de veículos
- ✅ Remoção de veículos
- ✅ Listagem de veículos
- ✅ Cálculo correto de valores
- ✅ Tratamento de veículo não encontrado
- ✅ Comparação case-insensitive de placas
- ✅ Lista vazia

**Cenários de Borda:**
- ✅ 0 horas estacionado
- ✅ Múltiplas horas
- ✅ Preços diferentes
- ✅ Placas em diferentes casos (maiúscula/minúscula)

### 6. Melhorias Sugeridas

Para tornar o projeto ainda mais robusto, considere:

1. **Validação de Entrada:**
   - Validar formato de placa
   - Validar horas negativas
   - Tratar entrada não numérica

2. **Persistência:**
   - Salvar dados em arquivo
   - Carregar dados na inicialização

3. **Logs:**
   - Adicionar logging das operações
   - Histórico de transações

4. **Interface:**
   - Melhorar formatação da saída
   - Adicionar cores no console
