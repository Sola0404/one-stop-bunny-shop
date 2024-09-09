import { useEffect, useState } from "react";
import { Product } from "../models/product";
import Catalog from "../../features/catalog/Catalog";
import { Typography } from "@mui/material";

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
			<Typography variant="h1">One Stop Bunny Shop</Typography>
			<Catalog products={products} addProduct={addProduct} />
		</div>
	);
}

export default App;
