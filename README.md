# Sistema de gerenciamento de reservas para um hotel

Um sistema de gerenciamento de reservas para hotéis que permite aos clientes configurar pacotes de hospedagem personalizados. O sistema permite organizar diferentes níveis de pacotes e gerencia o estado das reservas.

## Padrões de projetos utilizados: Builder, Composite, e State

Como os padrões são aplicados:
- Builder: Constrói pacotes de hospedagem personalizados, onde o cliente pode escolher diferentes opções e complementos, como tipo de quarto, refeições e serviços adicionais.
- Composite: Organiza pacotes de serviços ou tipos de acomodações (ex.: suítes e quartos simples podem ser agrupados para pacotes).
- State: Controla o estado da reserva, como “pendente”, “em andamento”, “confirmado” e “finalizado”, alterando o comportamento do sistema de acordo com o estado atual.
