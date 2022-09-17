import Button from 'react-bootstrap/Button';
import Card from 'react-bootstrap/Card';
import Row from 'react-bootstrap/Row';
import Col from 'react-bootstrap/Col';
import Container from 'react-bootstrap/esm/Container';

function Carditem({ productname, productUrl, prodesc}) {
    return (

        <Col style={{ padding: '1rem'}} >
            <Card>
                <Card.Media image={productUrl} title={productname}/>
            <Card.Content>
                    <Card.Title style={{ fontsize: '1rem', textAlign: 'centre' }}>{productname}</Card.Title>
                    <Card.Text style={{ fontsize: '1rem', textAlign: 'centre', textAlign: 'left' }}>{prodesc}</Card.Text>
                </Card.Content>sdfsdfds
                <Card.Actions><Button style={{ width: '8rem', height: '2rem', fontsize: '1rem', textAlign: 'centre' }} variant="primary">Add to Cart</Button>
                </Card.Actions>
        </Card>
        </Col>
    
    );
}

export default Carditem;