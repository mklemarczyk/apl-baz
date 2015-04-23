<?php

use yii\helpers\Html;


/* @var $this yii\web\View */
/* @var $model common\models\Samolot */

$this->title = 'Create Samolot';
$this->params['breadcrumbs'][] = ['label' => 'Samolots', 'url' => ['index']];
$this->params['breadcrumbs'][] = $this->title;
?>
<div class="samolot-create">

    <h1><?= Html::encode($this->title) ?></h1>

    <?= $this->render('_form', [
        'model' => $model,
    ]) ?>

</div>
