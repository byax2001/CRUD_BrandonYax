import { FormControl, FormGroup } from '@angular/forms';
import { Envase } from '../../Interfaces/Envase';
import { Producto } from '../../Interfaces/Producto';
import { CilindroService } from '../../services/cilindros.service';
import { Component, OnInit } from '@angular/core';
import { Cilindro } from '../../Interfaces/Cilindro';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Route, Router } from '@angular/router';

@Component({
  selector: 'create-cilindro',
  standalone: false,

  templateUrl: './create-cilindro.component.html',
  styleUrl: './create-cilindro.component.css'
})
export class CreateCilindroComponent implements OnInit {
  public envases:Envase[] = [
  ];
  public productos:Producto[] = [
  ]
  constructor(
    private cilindroService:CilindroService,
    private snackbar: MatSnackBar,
    private router: Router

  ) { }

  public cilindroForm: FormGroup = new FormGroup({
    serie:                new FormControl(''),
    idenvase:             new FormControl(-1),
    idproducto:           new FormControl(-1),
    capacidad:            new FormControl(-1),
})



  ngOnInit(): void {
    this.cilindroService.getEnvases().subscribe(
      res => {
        this.envases = this.envases.concat(res);
      }
    )
    this.cilindroService.getProductos().subscribe(
      res => {
        this.productos = this.productos.concat(res);
      }
    )
  }

  get currenCilindro(): Cilindro {
    const cilindro = this.cilindroForm.value as Cilindro;
    return cilindro;
  }
  onSubmit(){

    this.cilindroService.postCilindro(this.currenCilindro).subscribe(
      res => {
        if(res){
          this.showSnackbar('Cilindro creado correctamente');
          this.router.navigate(['cil/cilindros']);
        }
      }
    )
  }

  showSnackbar( message: string ):void { //Muestra un modal en la parte inferior de la pantalla con un mensaje y un boton de cerrar
    // que funciona como una alerta snackbar
    this.snackbar.open( message, 'done', {
      duration: 2500,
    })
  }

}
