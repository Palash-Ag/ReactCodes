import { useEffect, useState } from 'react';
import Catalog from '../features/catalog/Catalog';
import NavBar from '../features/Headers/NavBar';
import '../layouts/App.css';

function App() {
    const [products, setProducts] = useState([]);
    useEffect(() => {
        fetch('https://localhost:44352/api/products')
            .then(response => response.json())
            .then(data => setProducts(data));
    }, []);
  return (
      <div className="App">
          <NavBar/>
          <Catalog products={products}/>
    </div>
  );
}

export default App;
