import React, { Component } from 'react';

export class NoteData extends Component {
  static displayName = NoteData.name;

  constructor(props) {
    super(props);
    this.state = {
      error: null,
      isLoaded: false,
      resultData: []
    };
  }

    componentDidMount() {
    fetch("https://localhost:1998/notes")
    .then(res => res.json())
    .then(
      (result) => {
        this.setState({
          isLoaded: true,
          resultData: result
        });

        console.log(this.state.resultData);
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
    const { error, isLoaded, resultData } = this.state;
    if (error) {
      return <div>Error: {error.message}</div>;
    } else if (!isLoaded) {
      return <div>Loading...</div>;
    } else {
      return (
        <ul>
          {resultData.map(item => (
            <li key={item.id}>
              {item.name} {item.description}  {item.createdDate}  
            </li>
          ))}
        </ul>
      );
    }
  }

 
}
