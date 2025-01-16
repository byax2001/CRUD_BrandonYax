
import { Component, OnInit } from '@angular/core';
import { CilindroService } from '../../services/cilindros.service';
import { Cilindro } from '../../Interfaces/Cilindro';
import { MatSnackBar } from '@angular/material/snack-bar';
import { CilindroJoin } from '../../Interfaces/CilindroJoin';

@Component({
  selector: 'tables-cilindros',
  standalone: false,

  templateUrl: './tables-cilindros.component.html',
  styleUrl: './tables-cilindros.component.css'
})
export class TablesCilindrosComponent implements OnInit{
  public data:CilindroJoin[] = [];
  public displayedColumns: string[] = ['id', 'serie', 'envase', 'producto', 'capacidad', 'eliminar'];
  constructor(
    private cilindroService: CilindroService,
    private snackbar: MatSnackBar
  ) { }

  ngOnInit(): void {
    this.cilindroService.getCilindros().subscribe(
      res => {
        this.data = this.data.concat(res);
      }
    )
  }

  eliminarCil(cilindro: Cilindro){
    this.cilindroService.deletCilindro(cilindro.id).subscribe(
      res => {
        if(res){
          this.data = this.data.filter(c => c.id !== cilindro.id);
          this.showSnackbar('Cilindro eliminado correctamente');
        }
      }
    )
  }

  showSnackbar(message: string){
    this.snackbar.open(message, 'Cerrar', {
      duration: 2000
    });
  }
}
