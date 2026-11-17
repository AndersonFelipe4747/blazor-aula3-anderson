# Componentes reutilizáveis em Blazor

O FormProduto não adiciona o produto direto na lista porque a lista não pertence a ele: ela é da página Produtos, e o formulário só coleta e valida os dados.
Quem adiciona é a página, no método ReceberProduto, que faz produtos.Add(produto).
Ela fica sabendo porque o FormProduto tem um EventCallback<Produto> (OnProdutoValido), no qual a página coloca o seu método; quando o cadastro é válido, o formulário chama InvokeAsync(novo) e a página recebe o produto.
Assim o mesmo formulário pode ser reaproveitado em outras telas, como Categorias, sem mexer no código dele.
