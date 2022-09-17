import Container from "react-bootstrap/esm/Container";
import Row from "react-bootstrap/Row";
import Carditem from "./Carditem";

function Catalog(props) {
    return (
        <Container>
            < Row md={5}>
        {props.products.map((item, index) => <Carditem key={index} productname={item.name} productUrl={"https://localhost:44352/StaticFiles".concat(item.pictureUrl)} prodesc={item.Description} />)}
        </Row></Container>);
}
export default Catalog;