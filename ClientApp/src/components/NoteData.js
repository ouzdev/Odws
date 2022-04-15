import React, { Component } from 'react';

export class NoteData extends Component {
  static displayName = NoteData.name;

  constructor(props) {
    super(props);
    this.state = {
      error: null,
      isLoaded: false,
      items: []
    };
  }

    componentDidMount() {
    fetch("https://localhost:1998/notes")
    .then(res => res.json())
    .then(
      (result) => {
        this.setState({
          isLoaded: true,
          items: result.items
        });

        console.log(result);
      },
      // Not: Burada hataları yakalamak önemlidir.
      // Bileşenimizde bug bulunmaması için, 'catch ()' bloğu yerine bulunan
      // bu blok içinde hatalar yakalanır.
      (error) => {
        this.setState({
          isLoaded: true,
          error
        });
      }
    )
  }


  render() {
    

    return (
      <div>
        <h1 id="tabelLabel" >Weather forecast</h1>
        <p>This component demonstrates fetching data from the server.</p>
      </div>

      
    );
  }

 
}
