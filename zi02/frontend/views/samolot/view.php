<?php

use yii\helpers\Html;
use yii\widgets\DetailView;

/* @var $this yii\web\View */
/* @var $model common\models\Samolot */

$this->title = $model->id;
$this->params['breadcrumbs'][] = ['label' => 'Samoloty', 'url' => ['index']];
$this->params['breadcrumbs'][] = $this->title;
?>
<div class="samolot-view">

    <h1><?= Html::encode($this->title) ?></h1>

    <p>
        <?= Html::a('Zmień', ['update', 'id' => $model->id], ['class' => 'btn btn-primary']) ?>
        <?= Html::a('Usuń', ['delete', 'id' => $model->id], [
            'class' => 'btn btn-danger',
            'data' => [
                'confirm' => 'Czy na pewno chcesz usunąć ten element?',
                'method' => 'post',
            ],
        ]) ?>
    </p>

    <?= DetailView::widget([
        'model' => $model,
        'attributes' => [
            // 'id',
            'model',
            'rok_produkcji',
            'liczba_miejsc',
        ],
    ]) ?>

</div>
