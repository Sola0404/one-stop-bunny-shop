import { useEffect, useState } from "react";
import { Product } from "../models/product";
import Catalog from "../../features/catalog/Catalog";

function App() {
	const [products, setProducts] = useState<Product[]>([]);

	useEffect(() => {
		fetch("http://localhost:5000/api/products")
			.then((response) => response.json())
			.then((data) => setProducts(data));
	}, []);

	function addProduct() {
		console.log("Adding product");
	}

	return (
		<div>
			<h1>One Stop Bunny Shop</h1>
			<Catalog products={products} addProduct={addProduct} />
		</div>
	);
}

export default App;
